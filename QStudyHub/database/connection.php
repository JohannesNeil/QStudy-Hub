<?php
declare(strict_types=1);

$config = require __DIR__ . '/../config/config.php';

function db(): PDO
{
	static $connection;

	if ($connection instanceof PDO) {
		return $connection;
	}

	global $config;
	$database = $config['database'];
	$dsn = sprintf(
		'mysql:host=%s;port=%s;dbname=%s;charset=utf8mb4',
		$database['host'],
		$database['port'],
		$database['name']
	);

	$connection = new PDO($dsn, $database['user'], $database['password'], [
		PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
		PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
		PDO::ATTR_EMULATE_PREPARES => false,
	]);

	return $connection;
}
