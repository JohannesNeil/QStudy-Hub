<?php
declare(strict_types=1);
require_once __DIR__ . '/includes/layout.php';

if (current_user() !== null) {
	redirect('dashboard.php');
}

$errors = [];
$fullName = '';
$email = '';
$username = '';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
	verify_csrf();
	$fullName = trim((string) ($_POST['full_name'] ?? ''));
	$email = strtolower(trim((string) ($_POST['email'] ?? '')));
	$username = trim((string) ($_POST['username'] ?? ''));
	$password = (string) ($_POST['password'] ?? '');
	$confirmation = (string) ($_POST['password_confirmation'] ?? '');

	if ($fullName === '' || mb_strlen($fullName) > 120) $errors[] = 'Enter a valid full name.';
	if (!filter_var($email, FILTER_VALIDATE_EMAIL) || mb_strlen($email) > 190) $errors[] = 'Enter a valid email address.';
	if (!preg_match('/^[A-Za-z0-9_]{3,50}$/', $username)) $errors[] = 'Username must be 3-50 letters, numbers, or underscores.';
	if (strlen($password) < 8) $errors[] = 'Password must be at least 8 characters.';
	if ($password !== $confirmation) $errors[] = 'Passwords do not match.';

	if (!$errors) {
		$check = db()->prepare('SELECT user_id FROM users WHERE email = :email OR username = :username LIMIT 1');
		$check->execute(['email' => $email, 'username' => $username]);
		if ($check->fetch()) {
			$errors[] = 'That email or username is already registered.';
		} else {
			$statement = db()->prepare('INSERT INTO users (full_name, email, username, password_hash) VALUES (:full_name, :email, :username, :password_hash)');
			$statement->execute([
				'full_name' => $fullName,
				'email' => $email,
				'username' => $username,
				'password_hash' => password_hash($password, PASSWORD_DEFAULT),
			]);
			flash('success', 'Your account was created. You can now log in.');
			redirect('login.php');
		}
	}
}

page_header('Create account');
?>
<div class="row justify-content-center"><div class="col-md-7 col-lg-5"><div class="card border-0 shadow-sm"><div class="card-body p-4 p-md-5">
<h1 class="h3 mb-4">Create your account</h1>
<?php if ($errors): ?><div class="alert alert-danger"><ul class="mb-0"><?php foreach ($errors as $error): ?><li><?= e($error) ?></li><?php endforeach; ?></ul></div><?php endif; ?>
<form method="post" novalidate>
<input type="hidden" name="csrf_token" value="<?= e(csrf_token()) ?>">
<div class="mb-3"><label class="form-label" for="full_name">Full name</label><input class="form-control" id="full_name" name="full_name" required value="<?= e($fullName) ?>"></div>
<div class="mb-3"><label class="form-label" for="email">Email</label><input class="form-control" type="email" id="email" name="email" required value="<?= e($email) ?>"></div>
<div class="mb-3"><label class="form-label" for="username">Username</label><input class="form-control" id="username" name="username" required value="<?= e($username) ?>"></div>
<div class="mb-3"><label class="form-label" for="password">Password</label><input class="form-control" type="password" id="password" name="password" required minlength="8"></div>
<div class="mb-4"><label class="form-label" for="password_confirmation">Confirm password</label><input class="form-control" type="password" id="password_confirmation" name="password_confirmation" required minlength="8"></div>
<button class="btn btn-primary w-100" type="submit">Sign up</button>
</form><p class="text-center text-secondary mt-4 mb-0">Already registered? <a href="login.php">Log in</a></p>
</div></div></div></div>
<?php page_footer(); ?>
