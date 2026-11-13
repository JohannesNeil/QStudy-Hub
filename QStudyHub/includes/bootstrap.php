<?php
declare(strict_types=1);

require_once __DIR__ . '/../database/connection.php';

if (session_status() !== PHP_SESSION_ACTIVE) {
	session_set_cookie_params([
		'httponly' => true,
		'secure' => !empty($_SERVER['HTTPS']) && $_SERVER['HTTPS'] !== 'off',
		'samesite' => 'Lax',
	]);
	session_start();
}

function e(?string $value): string
{
	return htmlspecialchars($value ?? '', ENT_QUOTES | ENT_SUBSTITUTE, 'UTF-8');
}

function csrf_token(): string
{
	if (empty($_SESSION['csrf_token'])) {
		$_SESSION['csrf_token'] = bin2hex(random_bytes(32));
	}

	return $_SESSION['csrf_token'];
}

function verify_csrf(): void
{
	$token = $_POST['csrf_token'] ?? '';
	if (!is_string($token) || !hash_equals($_SESSION['csrf_token'] ?? '', $token)) {
		http_response_code(419);
		exit('Invalid form token. Please go back and try again.');
	}
}

function redirect(string $path): never
{
	header('Location: ' . $path);
	exit;
}

function flash(string $key, ?string $message = null): ?string
{
	if ($message !== null) {
		$_SESSION['flash'][$key] = $message;
		return null;
	}

	$value = $_SESSION['flash'][$key] ?? null;
	unset($_SESSION['flash'][$key]);
	return $value;
}
