# QStudy Hub PHP Web Application

This directory is a separate PHP/MySQL web application. The existing `.NET 10` WinForms project remains unchanged.

## Requirements

- PHP 8.1+ with PDO MySQL enabled
- MySQL 8+ or compatible MariaDB
- Apache, Nginx, or PHP's development server

## Setup

1. Create a database and tables by importing `sql/qstudyhub.sql`:

   ```bash
   mysql -u root -p < sql/qstudyhub.sql
   ```

2. Copy `.env.example` to `.env` and set your database values. The application reads environment variables from the web-server/process environment; configure those values in Apache, Nginx/PHP-FPM, or your local launcher.

3. Start the development server from this directory after exporting the variables:

   ```bash
   php -S localhost:8000
   ```

4. Open `http://localhost:8000` and create an account.

## Current foundation

- PDO with native prepared statements and UTF-8 support
- Session authentication with session ID regeneration on login
- CSRF token validation for forms
- Server-side validation and output escaping
- `password_hash()` and `password_verify()` for credentials
- Initial protected dashboard queries
- Full schema for the planned notes, schedules, planner, assignments, reviewers, goals, notifications, and progress modules

The module directories are reserved for the next increment of CRUD and upload handlers.
