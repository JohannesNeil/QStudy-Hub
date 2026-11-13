<?php
declare(strict_types=1);

require_once __DIR__ . '/bootstrap.php';

function current_user(): ?array
{
	static $loaded = false;
	static $user = null;

	if ($loaded) {
		return $user;
	}

	$loaded = true;
	$userId = $_SESSION['user_id'] ?? null;
	if (!is_int($userId) && !ctype_digit((string) $userId)) {
		return null;
	}

	$statement = db()->prepare(
		'SELECT user_id, full_name, email, username, profile_picture, created_at, last_login
		 FROM users WHERE user_id = :user_id AND status = "Active" LIMIT 1'
	);
	$statement->execute(['user_id' => (int) $userId]);
	$user = $statement->fetch() ?: null;

	if ($user === null) {
		unset($_SESSION['user_id']);
	}

	return $user;
}

function require_auth(): array
{
	$user = current_user();
	if ($user === null) {
		flash('error', 'Please log in to continue.');
		redirect('login.php');
	}

	return $user;
}

function login_user(int $userId): void
{
	session_regenerate_id(true);
	$_SESSION['user_id'] = $userId;
}

function logout_user(): void
{
	$_SESSION = [];
	if (ini_get('session.use_cookies')) {
		$params = session_get_cookie_params();
		setcookie(session_name(), '', time() - 42000, $params['path'], $params['domain'], (bool) $params['secure'], (bool) $params['httponly']);
	}
	session_destroy();
}
