CREATE DATABASE IF NOT EXISTS qstudyhub
	CHARACTER SET utf8mb4
	COLLATE utf8mb4_unicode_ci;

USE qstudyhub;

CREATE TABLE IF NOT EXISTS users (
	user_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	full_name VARCHAR(120) NOT NULL,
	email VARCHAR(190) NOT NULL,
	username VARCHAR(50) NOT NULL,
	password_hash VARCHAR(255) NOT NULL,
	profile_picture VARCHAR(255) NULL,
	created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	last_login TIMESTAMP NULL DEFAULT NULL,
	status ENUM('Active', 'Inactive') NOT NULL DEFAULT 'Active',
	PRIMARY KEY (user_id),
	UNIQUE KEY uq_users_email (email),
	UNIQUE KEY uq_users_username (username)
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS notes (
	note_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	user_id INT UNSIGNED NOT NULL,
	title VARCHAR(180) NOT NULL,
	subject VARCHAR(120) NOT NULL,
	content MEDIUMTEXT NOT NULL,
	created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	updated_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY (note_id),
	KEY idx_notes_user_updated (user_id, updated_at),
	CONSTRAINT fk_notes_user FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS schedules (
	schedule_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	user_id INT UNSIGNED NOT NULL,
	subject VARCHAR(120) NOT NULL,
	day ENUM('Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday') NOT NULL,
	start_time TIME NOT NULL,
	end_time TIME NOT NULL,
	location VARCHAR(180) NULL,
	created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (schedule_id),
	KEY idx_schedules_user_day (user_id, day, start_time),
	CONSTRAINT fk_schedules_user FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS study_planner (
	planner_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	user_id INT UNSIGNED NOT NULL,
	task_name VARCHAR(180) NOT NULL,
	description TEXT NULL,
	due_date DATE NOT NULL,
	status ENUM('Pending', 'In Progress', 'Completed') NOT NULL DEFAULT 'Pending',
	created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (planner_id),
	KEY idx_planner_user_due (user_id, due_date, status),
	CONSTRAINT fk_planner_user FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS assignments (
	assignment_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	user_id INT UNSIGNED NOT NULL,
	subject VARCHAR(120) NOT NULL,
	title VARCHAR(180) NOT NULL,
	description TEXT NULL,
	due_date DATE NOT NULL,
	status ENUM('Pending', 'In Progress', 'Completed') NOT NULL DEFAULT 'Pending',
	created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (assignment_id),
	KEY idx_assignments_user_due (user_id, due_date, status),
	CONSTRAINT fk_assignments_user FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS reviewers (
	reviewer_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	user_id INT UNSIGNED NOT NULL,
	title VARCHAR(180) NOT NULL,
	subject VARCHAR(120) NOT NULL,
	file_name VARCHAR(255) NOT NULL,
	file_path VARCHAR(255) NOT NULL,
	upload_date TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (reviewer_id),
	KEY idx_reviewers_user_date (user_id, upload_date),
	CONSTRAINT fk_reviewers_user FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS study_goals (
	goal_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	user_id INT UNSIGNED NOT NULL,
	goal_name VARCHAR(180) NOT NULL,
	target_count INT UNSIGNED NOT NULL DEFAULT 0,
	completed_count INT UNSIGNED NOT NULL DEFAULT 0,
	status ENUM('Pending', 'In Progress', 'Completed') NOT NULL DEFAULT 'Pending',
	created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (goal_id),
	KEY idx_goals_user_status (user_id, status),
	CONSTRAINT fk_goals_user FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS notifications (
	notification_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	user_id INT UNSIGNED NOT NULL,
	message VARCHAR(500) NOT NULL,
	type VARCHAR(50) NOT NULL DEFAULT 'General',
	is_read TINYINT(1) NOT NULL DEFAULT 0,
	created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (notification_id),
	KEY idx_notifications_user_read (user_id, is_read, created_at),
	CONSTRAINT fk_notifications_user FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
) ENGINE=InnoDB;

CREATE TABLE IF NOT EXISTS progress (
	progress_id INT UNSIGNED NOT NULL AUTO_INCREMENT,
	user_id INT UNSIGNED NOT NULL,
	assignments_percentage DECIMAL(5,2) NOT NULL DEFAULT 0.00,
	goals_percentage DECIMAL(5,2) NOT NULL DEFAULT 0.00,
	notes_percentage DECIMAL(5,2) NOT NULL DEFAULT 0.00,
	productivity_percentage DECIMAL(5,2) NOT NULL DEFAULT 0.00,
	last_updated TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
	PRIMARY KEY (progress_id),
	UNIQUE KEY uq_progress_user (user_id),
	CONSTRAINT fk_progress_user FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
) ENGINE=InnoDB;
