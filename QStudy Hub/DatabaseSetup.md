# WinForms database authentication setup

The WinForms login and signup forms use the same MySQL `qstudyhub.users` table as the PHP application.

## 1. Create the database

From the repository root, import `QStudyHub/sql/qstudyhub.sql` into MySQL:

```powershell
mysql -u root -p < QStudyHub/sql/qstudyhub.sql
```

## 2. Configure connection settings

The application reads these environment variables:

- `QSTUDY_DB_HOST` (default: `127.0.0.1`)
- `QSTUDY_DB_PORT` (default: `3306`)
- `QSTUDY_DB_NAME` (default: `qstudyhub`)
- `QSTUDY_DB_USER` (default: `root`)
- `QSTUDY_DB_PASSWORD` (default: empty)
- `QSTUDY_DB_CONNECTION_STRING` (optional; overrides the individual settings)

For the current PowerShell session:

```powershell
$env:QSTUDY_DB_HOST = '127.0.0.1'
$env:QSTUDY_DB_PORT = '3306'
$env:QSTUDY_DB_NAME = 'qstudyhub'
$env:QSTUDY_DB_USER = 'qstudy_app'
$env:QSTUDY_DB_PASSWORD = 'replace-with-a-local-secret'
```

Do not commit passwords or a production connection string to the repository. Prefer a MySQL account limited to the `qstudyhub` database instead of using `root`.

## 3. Run the application

Start Visual Studio from the configured environment, or launch it from the same PowerShell session so the process inherits the variables. Signup creates a BCrypt password hash in `users.password_hash`; login verifies that hash and updates `users.last_login`.
