<?php
declare(strict_types=1);

const APP_NAME = 'QStudy Hub';

function env_value(string $key, string $default = ''): string
{
	$value = getenv($key);
	return $value === false ? $default : $value;
}

$appEnvironment = env_value('APP_ENV', 'development');

date_default_timezone_set(env_value('APP_TIMEZONE', 'UTC'));

return [
	'environment' => $appEnvironment,
	'debug' => $appEnvironment !== 'production',
	'database' => [
		'host' => env_value('DB_HOST', '127.0.0.1'),
		'port' => env_value('DB_PORT', '3306'),
		'name' => env_value('DB_NAME', 'qstudyhub'),
		'user' => env_value('DB_USER', 'root'),
		'password' => env_value('DB_PASSWORD'),
	],
];
