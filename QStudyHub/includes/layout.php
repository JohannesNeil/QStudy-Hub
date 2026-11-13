<?php
declare(strict_types=1);

require_once __DIR__ . '/auth.php';

function page_header(string $title, bool $authenticated = false): void
{
	$user = $authenticated ? current_user() : null;
	?><!doctype html>
<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title><?= e($title) ?> | <?= e(APP_NAME) ?></title>
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
	<link href="assets/css/app.css" rel="stylesheet">
</head>
<body class="bg-light">
<nav class="navbar navbar-expand-lg navbar-dark bg-primary shadow-sm">
	<div class="container">
		<a class="navbar-brand fw-bold" href="<?= $authenticated ? 'dashboard.php' : 'index.php' ?>">QStudy Hub</a>
		<div class="d-flex align-items-center gap-3">
			<?php if ($user): ?>
				<span class="text-white small">Hi, <?= e($user['full_name']) ?></span>
				<a class="btn btn-outline-light btn-sm" href="logout.php">Logout</a>
			<?php endif; ?>
		</div>
	</div>
</nav>
<main class="container py-4">
<?php
}

function page_footer(): void
{
	?></main>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
<?php
}
