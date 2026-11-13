<?php
declare(strict_types=1);
require_once __DIR__ . '/includes/layout.php';

$user = require_auth();
$userId = (int) $user['user_id'];

$summaryQuery = db()->prepare(
	'SELECT
		(SELECT COUNT(*) FROM assignments WHERE user_id = :assignments_user_id AND status = "Completed") AS assignments_completed,
		(SELECT COUNT(*) FROM study_goals WHERE user_id = :goals_user_id AND status = "Completed") AS goals_finished,
		(SELECT COUNT(*) FROM reviewers WHERE user_id = :reviewers_user_id) AS reviewers_read,
		(SELECT COUNT(*) FROM notes WHERE user_id = :notes_user_id) AS notes_count'
);
$summaryQuery->execute([
	'assignments_user_id' => $userId,
	'goals_user_id' => $userId,
	'reviewers_user_id' => $userId,
	'notes_user_id' => $userId,
]);
$summary = $summaryQuery->fetch();

$planner = db()->prepare('SELECT task_name, due_date, status FROM study_planner WHERE user_id = :user_id ORDER BY due_date ASC LIMIT 5');
$planner->execute(['user_id' => $userId]);
$tasks = $planner->fetchAll();

page_header('Dashboard', true);
?>
<div class="d-flex justify-content-between align-items-center mb-4"><div><p class="text-primary fw-semibold mb-1">OVERVIEW</p><h1 class="h2 mb-0">Study dashboard</h1></div><a class="btn btn-primary" href="notes/create.php">+ New note</a></div>
<div class="row g-3 mb-4">
<?php foreach ([['Assignments Completed', $summary['assignments_completed'], 'bi-check2-circle'], ['Study Goals Finished', $summary['goals_finished'], 'bi-trophy'], ['Review Materials', $summary['reviewers_read'], 'bi-book'], ['Notes Created', $summary['notes_count'], 'bi-journal-text']] as [$label, $value, $icon]): ?><div class="col-sm-6 col-xl-3"><div class="card border-0 shadow-sm h-100"><div class="card-body"><p class="text-secondary small mb-2"><?= e($label) ?></p><div class="display-6 fw-bold text-primary"><?= e((string) $value) ?></div></div></div></div><?php endforeach; ?>
</div>
<div class="row g-4"><div class="col-lg-7"><div class="card border-0 shadow-sm"><div class="card-body"><div class="d-flex justify-content-between mb-3"><h2 class="h5 mb-0">Study planner</h2><a href="planner/" class="small">View all</a></div><?php if (!$tasks): ?><p class="text-secondary mb-0">No planner tasks yet. Add your first study task to get started.</p><?php else: ?><div class="list-group list-group-flush"><?php foreach ($tasks as $task): ?><div class="list-group-item px-0 d-flex justify-content-between"><span><?= e($task['task_name']) ?></span><span class="badge text-bg-light"><?= e($task['status']) ?> · <?= e($task['due_date']) ?></span></div><?php endforeach; ?></div><?php endif; ?></div></div></div><div class="col-lg-5"><div class="card border-0 shadow-sm"><div class="card-body"><h2 class="h5">Quick actions</h2><div class="d-grid gap-2"><a class="btn btn-outline-primary text-start" href="notes/">Manage notes</a><a class="btn btn-outline-primary text-start" href="assignments/">Manage assignments</a><a class="btn btn-outline-primary text-start" href="schedules/">View schedule</a><a class="btn btn-outline-primary text-start" href="reviewers/">Upload reviewer</a></div></div></div></div></div>
<?php page_footer(); ?>
