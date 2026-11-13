<?php
require_once __DIR__ . '/includes/layout.php';

if (current_user() !== null) {
	redirect('dashboard.php');
}

page_header('Welcome');
$error = flash('error');
$success = flash('success');
?>
<div class="row align-items-center g-5 py-5">
	<div class="col-lg-7">
		<p class="text-primary fw-semibold mb-2">STUDY SMARTER</p>
		<h1 class="display-4 fw-bold">Your focused space for better study habits.</h1>
		<p class="lead text-secondary">Organize notes, assignments, schedules, study goals, and review materials in one secure hub.</p>
		<div class="d-flex gap-2">
			<a class="btn btn-primary btn-lg" href="register.php">Create account</a>
			<a class="btn btn-outline-primary btn-lg" href="login.php">Log in</a>
		</div>
	</div>
	<div class="col-lg-5"><div class="hero-card p-5 rounded-4 shadow-sm"><h2 class="h4">Everything in one place</h2><p class="mb-0 text-secondary">The database foundation is ready for notes, schedules, planner tasks, assignments, reviewers, goals, notifications, and progress tracking.</p></div></div>
</div>
<?php page_footer(); ?>
