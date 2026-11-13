<?php
declare(strict_types=1);
require_once __DIR__ . '/includes/layout.php';

if (current_user() !== null) redirect('dashboard.php');
$error = null;
$emailOrUsername = '';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
	verify_csrf();
	$emailOrUsername = trim((string) ($_POST['email_or_username'] ?? ''));
	$password = (string) ($_POST['password'] ?? '');
	$statement = db()->prepare('SELECT user_id, password_hash, status FROM users WHERE email = :email OR username = :username LIMIT 1');
	$statement->execute(['email' => $emailOrUsername, 'username' => $emailOrUsername]);
	$user = $statement->fetch();

	if (!$user || $user['status'] !== 'Active' || !password_verify($password, $user['password_hash'])) {
		$error = 'The provided login details are incorrect.';
	} else {
		login_user((int) $user['user_id']);
		db()->prepare('UPDATE users SET last_login = CURRENT_TIMESTAMP WHERE user_id = :user_id')->execute(['user_id' => $user['user_id']]);
		redirect('dashboard.php');
	}
}

page_header('Log in');
$success = flash('success');
$flashError = flash('error');
?>
<div class="row justify-content-center"><div class="col-md-7 col-lg-5"><div class="card border-0 shadow-sm"><div class="card-body p-4 p-md-5">
<h1 class="h3 mb-4">Welcome back</h1>
<?php if ($success): ?><div class="alert alert-success"><?= e($success) ?></div><?php endif; ?>
<?php if ($error || $flashError): ?><div class="alert alert-danger"><?= e($error ?? $flashError) ?></div><?php endif; ?>
<form method="post">
<input type="hidden" name="csrf_token" value="<?= e(csrf_token()) ?>">
<div class="mb-3"><label class="form-label" for="email_or_username">Email or username</label><input class="form-control" id="email_or_username" name="email_or_username" required value="<?= e($emailOrUsername) ?>"></div>
<div class="mb-4"><label class="form-label" for="password">Password</label><input class="form-control" type="password" id="password" name="password" required></div>
<button class="btn btn-primary w-100" type="submit">Log in</button>
</form><p class="text-center text-secondary mt-4 mb-0">Need an account? <a href="register.php">Sign up</a></p>
</div></div></div></div>
<?php page_footer(); ?>
