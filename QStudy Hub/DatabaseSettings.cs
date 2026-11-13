using MySqlConnector;

namespace QStudy_Hub;

internal static class DatabaseSettings
{
    public static string ConnectionString
    {
        get
        {
            var configuredConnectionString = Environment.GetEnvironmentVariable("QSTUDY_DB_CONNECTION_STRING");
            if (!string.IsNullOrWhiteSpace(configuredConnectionString))
            {
                return configuredConnectionString;
            }

            var builder = new MySqlConnectionStringBuilder
            {
                Server = Environment.GetEnvironmentVariable("QSTUDY_DB_HOST") ?? "127.0.0.1",
                Port = GetPort(),
                Database = Environment.GetEnvironmentVariable("QSTUDY_DB_NAME") ?? "qstudyhub",
                UserID = Environment.GetEnvironmentVariable("QSTUDY_DB_USER") ?? "root",
                Password = Environment.GetEnvironmentVariable("QSTUDY_DB_PASSWORD") ?? string.Empty,
                SslMode = MySqlSslMode.Preferred,
                AllowUserVariables = false,
                AllowPublicKeyRetrieval = false,
            };

            return builder.ConnectionString;
        }
    }

    public static string DescribeConnectionError(MySqlException exception)
    {
        return exception.Number switch
        {
            1045 => "MySQL rejected the username or password.",
            1049 => "The qstudyhub database does not exist.",
            2003 => "MySQL is not accepting connections on the configured host and port.",
            0 => "MySQL is not accepting connections on the configured host and port.",
            _ => $"MySQL returned error {exception.Number}: {exception.Message}",
        };
    }

    private static uint GetPort()
    {
        return uint.TryParse(Environment.GetEnvironmentVariable("QSTUDY_DB_PORT"), out var port)
            ? port
            : 3306;
    }
}