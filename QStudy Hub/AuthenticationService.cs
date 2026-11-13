using MySqlConnector;

namespace QStudy_Hub;

internal enum RegistrationResult
{
    Success,
    DuplicateEmail,
    DuplicateUsername,
}

internal sealed record AuthenticatedUser(int UserId, string FullName, string Username, string Email);

internal sealed class AuthenticationService
{
    public async Task<RegistrationResult> RegisterAsync(
        string fullName,
        string email,
        string username,
        string password,
        CancellationToken cancellationToken = default)
    {
        await using var connection = new MySqlConnection(DatabaseSettings.ConnectionString);
        await connection.OpenAsync(cancellationToken);

        await using (var duplicateCommand = connection.CreateCommand())
        {
            duplicateCommand.CommandText = """
                SELECT email, username
                FROM users
                WHERE email = @email OR username = @username
                LIMIT 1;
                """;
            duplicateCommand.Parameters.AddWithValue("@email", email);
            duplicateCommand.Parameters.AddWithValue("@username", username);

            await using var reader = await duplicateCommand.ExecuteReaderAsync(cancellationToken);
            if (await reader.ReadAsync(cancellationToken))
            {
                var existingEmail = reader.GetString("email");
                return string.Equals(existingEmail, email, StringComparison.OrdinalIgnoreCase)
                    ? RegistrationResult.DuplicateEmail
                    : RegistrationResult.DuplicateUsername;
            }
        }

        await using var insertCommand = connection.CreateCommand();
        insertCommand.CommandText = """
            INSERT INTO users (full_name, email, username, password_hash)
            VALUES (@full_name, @email, @username, @password_hash);
            """;
        insertCommand.Parameters.AddWithValue("@full_name", fullName);
        insertCommand.Parameters.AddWithValue("@email", email);
        insertCommand.Parameters.AddWithValue("@username", username);
        insertCommand.Parameters.AddWithValue("@password_hash", BCrypt.Net.BCrypt.HashPassword(password));

        try
        {
            await insertCommand.ExecuteNonQueryAsync(cancellationToken);
            return RegistrationResult.Success;
        }
        catch (MySqlException exception) when (exception.Number == 1062)
        {
            return RegistrationResult.DuplicateEmail;
        }
    }

    public async Task<AuthenticatedUser?> LoginAsync(
        string emailOrUsername,
        string password,
        CancellationToken cancellationToken = default)
    {
        await using var connection = new MySqlConnection(DatabaseSettings.ConnectionString);
        await connection.OpenAsync(cancellationToken);

        await using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT user_id, full_name, email, username, password_hash
            FROM users
            WHERE (email = @email OR username = @username) AND status = 'Active'
            LIMIT 1;
            """;
        command.Parameters.AddWithValue("@email", emailOrUsername);
        command.Parameters.AddWithValue("@username", emailOrUsername);

        await using var reader = await command.ExecuteReaderAsync(cancellationToken);
        if (!await reader.ReadAsync(cancellationToken))
        {
            return null;
        }

        var passwordHash = reader.GetString("password_hash");
        if (!BCrypt.Net.BCrypt.Verify(password, passwordHash))
        {
            return null;
        }

        var user = new AuthenticatedUser(
            reader.GetInt32("user_id"),
            reader.GetString("full_name"),
            reader.GetString("username"),
            reader.GetString("email"));

        await reader.DisposeAsync();

        await using var updateCommand = connection.CreateCommand();
        updateCommand.CommandText = "UPDATE users SET last_login = CURRENT_TIMESTAMP WHERE user_id = @user_id;";
        updateCommand.Parameters.AddWithValue("@user_id", user.UserId);
        await updateCommand.ExecuteNonQueryAsync(cancellationToken);

        return user;
    }
}
