using System.Drawing.Drawing2D;
using QStudy_Hub.User_Controls;

namespace QStudy_Hub
{
    public partial class Dashboard : Form
    {
        private static readonly Color Navy = Color.FromArgb(21, 39, 78);
        private static readonly Color Blue = Color.FromArgb(48, 111, 240);
        private static readonly Color LightBlue = Color.FromArgb(239, 244, 253);
        private static readonly Color Canvas = Color.FromArgb(246, 248, 253);
        private static readonly Color Ink = Color.FromArgb(24, 42, 78);
        private static readonly Color Muted = Color.FromArgb(99, 114, 143);
        private readonly string username;

        public Dashboard(string username)
        {
            this.username = username;
            InitializeComponent();
            BuildDashboard();
        }

        private void BuildDashboard()
        {
            SuspendLayout();
            Controls.Clear();
            BackColor = Canvas;
            ClientSize = new Size(1240, 780);
            MinimumSize = new Size(1000, 650);
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Text = "QStudy Hub";

            Controls.Add(CreateMainContent());
            Controls.Add(CreateSidebar());
            ResumeLayout(true);
        }

        private Control CreateSidebar()
        {
            var sidebar = new Panel
            {
                BackColor = Navy,
                Dock = DockStyle.Left,
                Padding = new Padding(18, 22, 18, 18),
                Width = 235,
            };

            var logo = new Panel { Dock = DockStyle.Top, Height = 85 };
            logo.Controls.Add(new Label
            {
                AutoSize = true,
                Dock = DockStyle.Top,
                Font = new Font("Segoe UI", 23F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = "▣",
                TextAlign = ContentAlignment.MiddleCenter,
            });
            logo.Controls.Add(new Label
            {
                AutoSize = true,
                Dock = DockStyle.Bottom,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = "QStudy Hub",
                TextAlign = ContentAlignment.MiddleCenter,
            });
            sidebar.Controls.Add(logo);

            var nav = new FlowLayoutPanel
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                Padding = new Padding(0, 28, 0, 0),
                WrapContents = false,
            };
            nav.Controls.Add(CreateNavButton("⌂", "Dashboard", true, (_, _) => BuildDashboard()));
            nav.Controls.Add(CreateNavButton("▤", "Notes", false, (_, _) => ShowFeatureMessage("Notes")));
            nav.Controls.Add(CreateNavButton("▦", "Schedules", false, (_, _) => btncalendar_Click(this, EventArgs.Empty)));
            nav.Controls.Add(CreateNavButton("✓", "Study Planner", false, (_, _) => ShowFeatureMessage("Study Planner")));
            nav.Controls.Add(CreateNavButton("▣", "Assignments", false, (_, _) => ShowFeatureMessage("Assignments")));
            nav.Controls.Add(CreateNavButton("▰", "Reviewers", false, (_, _) => ShowFeatureMessage("Reviewers")));

            var divider = new Panel { BackColor = Color.FromArgb(61, 80, 119), Height = 1, Margin = new Padding(0, 16, 0, 12), Width = 195 };
            nav.Controls.Add(divider);
            nav.Controls.Add(CreateNavButton("●", "Profile", false, (_, _) => ShowFeatureMessage("Profile")));
            nav.Controls.Add(CreateNavButton("⚙", "Settings", false, (_, _) => ShowFeatureMessage("Settings")));

            var logout = CreateNavButton("↪", "Logout", false, btnExit_Click);
            logout.Margin = new Padding(0, 18, 0, 0);
            nav.Controls.Add(logout);
            sidebar.Controls.Add(nav);

            var quote = new Label
            {
                Dock = DockStyle.Bottom,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                ForeColor = Color.FromArgb(210, 220, 241),
                Height = 72,
                Text = "Organize. Study.\nSucceed.",
                TextAlign = ContentAlignment.MiddleCenter,
            };
            sidebar.Controls.Add(quote);
            return sidebar;
        }

        private Button CreateNavButton(string icon, string caption, bool active, EventHandler click)
        {
            var button = new Button
            {
                BackColor = active ? Color.FromArgb(52, 94, 210) : Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = Color.FromArgb(43, 76, 151) },
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.White,
                Height = 42,
                Margin = new Padding(0, 0, 0, 5),
                Text = $"  {icon}    {caption}",
                TextAlign = ContentAlignment.MiddleLeft,
                Width = 195,
            };
            button.Click += click;
            return button;
        }

        private Control CreateMainContent()
        {
            var main = new TableLayoutPanel
            {
                BackColor = Canvas,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Padding = new Padding(22, 18, 22, 18),
                RowCount = 4,
            };
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 112));
            main.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            main.Controls.Add(CreateHeader(), 0, 0);
            main.Controls.Add(CreateWelcomeBanner(), 0, 1);
            main.Controls.Add(CreateMetricStrip(), 0, 2);
            main.Controls.Add(CreateDashboardGrid(), 0, 3);
            return main;
        }

        private Control CreateHeader()
        {
            var header = new Panel { Dock = DockStyle.Fill };
            var search = new TextBox
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(232, 237, 248),
                BorderStyle = BorderStyle.None,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Muted,
                Margin = new Padding(0, 8, 12, 8),
                PlaceholderText = "⌕   Search anything...",
            };

            var profile = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Right,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Ink,
                Size = new Size(180, 38),
                Text = $"●  {username} ⌄",
                TextAlign = ContentAlignment.MiddleCenter,
            };
            var notification = new Label
            {
                Dock = DockStyle.Right,
                Font = new Font("Segoe UI", 18F),
                ForeColor = Navy,
                Size = new Size(40, 38),
                Text = "♟",
                TextAlign = ContentAlignment.MiddleCenter,
            };
            header.Controls.Add(profile);
            header.Controls.Add(notification);
            header.Controls.Add(search);
            return header;
        }

        private Control CreateWelcomeBanner()
        {
            var banner = new Panel { Dock = DockStyle.Fill, Padding = new Padding(20, 15, 20, 10) };
            banner.Paint += (_, e) =>
            {
                using var brush = new LinearGradientBrush(banner.ClientRectangle, Color.FromArgb(36, 90, 211), Color.FromArgb(94, 146, 255), 0F);
                e.Graphics.FillRectangle(brush, banner.ClientRectangle);
            };
            banner.Controls.Add(new Label
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.White,
                Text = $"Good Evening, {username}!",
            });
            banner.Controls.Add(new Label
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.White,
                Location = new Point(22, 61),
                Text = "Keep going! You’re doing great this semester. 💪",
            });
            banner.Controls.Add(new Label
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Dock = DockStyle.Right,
                Font = new Font("Segoe UI", 34F),
                ForeColor = Color.FromArgb(225, 238, 255),
                Size = new Size(220, 70),
                Text = "▱  ◇",
                TextAlign = ContentAlignment.MiddleCenter,
            });
            return banner;
        }

        private Control CreateMetricStrip()
        {
            var metrics = new TableLayoutPanel { ColumnCount = 4, Dock = DockStyle.Fill, RowCount = 1 };
            for (var i = 0; i < 4; i++) metrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            metrics.Controls.Add(CreateMetricCard("✓", "Assignments Completed", "—", "", Blue, 0), 0, 0);
            metrics.Controls.Add(CreateMetricCard("◎", "Study Goals Finished", "—", "", Color.FromArgb(31, 177, 112), 0), 1, 0);
            metrics.Controls.Add(CreateMetricCard("▣", "Review Materials Read", "—", "", Color.FromArgb(125, 75, 222), 0), 2, 0);
            metrics.Controls.Add(CreateMetricCard("↗", "Weekly Productivity", "—", "", Color.FromArgb(245, 164, 37), 0), 3, 0);
            return metrics;
        }

        private Control CreateMetricCard(string icon, string title, string value, string percent, Color accent, int progress)
        {
            var card = new Panel { BackColor = Color.White, Dock = DockStyle.Fill, Margin = new Padding(0, 8, 8, 4), Padding = new Padding(12, 10, 12, 8) };
            card.Paint += PaintCardBorder;
            var iconLabel = new Label { BackColor = Color.FromArgb(235, 241, 255), Dock = DockStyle.Left, Font = new Font("Segoe UI", 15F, FontStyle.Bold), ForeColor = accent, Size = new Size(40, 40), Text = icon, TextAlign = ContentAlignment.MiddleCenter };
            var details = new Panel { Dock = DockStyle.Fill, Padding = new Padding(10, 0, 0, 0) };
            details.Controls.Add(new Label { AutoSize = true, Font = new Font("Segoe UI", 8.5F), ForeColor = Muted, Location = new Point(10, 0), Text = title });
            details.Controls.Add(new Label { AutoSize = true, Font = new Font("Segoe UI", 16F, FontStyle.Bold), ForeColor = Ink, Location = new Point(10, 17), Text = value });
            if (percent.Length > 0) details.Controls.Add(new Label { Anchor = AnchorStyles.Bottom | AnchorStyles.Right, AutoSize = true, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = Ink, Location = new Point(130, 58), Text = percent });
            var bar = new ProgressBar { Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom, Height = 7, Location = new Point(10, 58), Maximum = 100, Style = ProgressBarStyle.Continuous, Value = progress };
            details.Controls.Add(bar);
            card.Controls.Add(details);
            card.Controls.Add(iconLabel);
            return card;
        }

        private Control CreateDashboardGrid()
        {
            var grid = new TableLayoutPanel { ColumnCount = 3, Dock = DockStyle.Fill, RowCount = 2 };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 58F));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            grid.Controls.Add(CreateScheduleCard(), 0, 0);
            grid.Controls.Add(CreatePlannerCard(), 1, 0);
            grid.Controls.Add(CreateProgressCard(), 2, 0);
            grid.Controls.Add(CreateNotesCard(), 0, 1);
            grid.Controls.Add(CreateAssignmentsCard(), 1, 1);
            grid.Controls.Add(CreateQuickActionsCard(), 2, 1);
            return grid;
        }

        private Panel CreateCard(string title, string icon)
        {
            var card = new Panel { BackColor = Color.White, Dock = DockStyle.Fill, Margin = new Padding(0, 6, 8, 8), Padding = new Padding(16, 12, 14, 12) };
            card.Paint += PaintCardBorder;
            var header = new Label { AutoSize = false, Dock = DockStyle.Top, Font = new Font("Segoe UI", 10F, FontStyle.Bold), ForeColor = Ink, Height = 28, Text = $"{icon}  {title}" };
            card.Controls.Add(header);
            card.ControlAdded += (_, _) => header.BringToFront();
            return card;
        }

        private void AddEmptyState(Panel card, string message)
        {
            card.Controls.Add(new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Muted,
                Text = message,
                TextAlign = ContentAlignment.MiddleCenter,
            });
        }

        private static void PaintCardBorder(object? sender, PaintEventArgs e)
        {
            if (sender is not Control control || control.Width < 2 || control.Height < 2)
            {
                return;
            }

            using var pen = new Pen(Color.FromArgb(222, 229, 242));
            e.Graphics.DrawRectangle(pen, 0, 0, control.Width - 1, control.Height - 1);
        }

        private Panel CreateScheduleCard()
        {
            var card = CreateCard("Upcoming Schedule", "▦");
            AddEmptyState(card, "No schedules yet.\nUse Add Schedule to add your first class.");
            return card;
        }

        private Panel CreatePlannerCard()
        {
            var card = CreateCard("My Study Planner", "✓");
            AddEmptyState(card, "No study tasks yet.\nUse Add Task to plan your study time.");
            return card;
        }

        private Panel CreateProgressCard()
        {
            var card = CreateCard("Progress Overview", "▥");
            AddEmptyState(card, "Progress will appear here\nafter you add study data.");
            return card;
        }

        private void AddProgressRow(FlowLayoutPanel flow, string title, int value, Color color)
        {
            var row = new Panel { Height = 36, Width = 300 };
            row.Controls.Add(new Label { AutoSize = true, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = Ink, Text = title });
            row.Controls.Add(new Label { Anchor = AnchorStyles.Top | AnchorStyles.Right, AutoSize = true, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = Ink, Location = new Point(260, 0), Text = $"{value}%" });
            row.Controls.Add(new ProgressBar { Location = new Point(0, 20), Size = new Size(285, 7), Maximum = 100, Style = ProgressBarStyle.Continuous, Value = value });
            flow.Controls.Add(row);
        }

        private Panel CreateNotesCard()
        {
            var card = CreateCard("Recent Notes", "▤");
            AddEmptyState(card, "No notes yet.\nCreate a note to see it here.");
            return card;
        }

        private Panel CreateAssignmentsCard()
        {
            var card = CreateCard("Latest Assignments", "▣");
            AddEmptyState(card, "No assignments yet.\nAdd an assignment to see it here.");
            return card;
        }

        private void AddList(Panel card, (string category, string title, string detail)[] rows)
        {
            var flow = new FlowLayoutPanel { AutoScroll = false, Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, Padding = new Padding(0, 12, 0, 0), WrapContents = false };
            foreach (var item in rows)
            {
                var line = new Panel { Height = 29, Width = 330, Margin = new Padding(0, 0, 0, 3) };
                line.Controls.Add(new Label { AutoSize = false, BackColor = LightBlue, Font = new Font("Segoe UI", 7.5F, FontStyle.Bold), ForeColor = Blue, Location = new Point(0, 2), Size = new Size(58, 22), Text = item.category, TextAlign = ContentAlignment.MiddleCenter });
                line.Controls.Add(new Label { AutoSize = true, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = Ink, Location = new Point(70, 5), Text = item.title });
                line.Controls.Add(new Label { Anchor = AnchorStyles.Top | AnchorStyles.Right, AutoSize = true, Font = new Font("Segoe UI", 8F), ForeColor = Muted, Location = new Point(220, 6), Text = item.detail });
                flow.Controls.Add(line);
            }
            card.Controls.Add(flow);
        }

        private Panel CreateQuickActionsCard()
        {
            var card = CreateCard("Quick Actions", "⚡");
            var actions = new TableLayoutPanel { ColumnCount = 2, Dock = DockStyle.Fill, Padding = new Padding(0, 12, 0, 0), RowCount = 2 };
            actions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            actions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            actions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            actions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            actions.Controls.Add(CreateActionButton("▤\nCreate Note", "Notes"), 0, 0);
            actions.Controls.Add(CreateActionButton("▦\nAdd Schedule", "Schedules"), 1, 0);
            actions.Controls.Add(CreateActionButton("✓\nAdd Task", "Study Planner"), 0, 1);
            actions.Controls.Add(CreateActionButton("⊕\nUpload Reviewer", "Reviewers"), 1, 1);
            card.Controls.Add(actions);
            return card;
        }

        private Button CreateActionButton(string text, string feature)
        {
            var button = new Button { BackColor = LightBlue, Dock = DockStyle.Fill, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 8F, FontStyle.Bold), ForeColor = Ink, Margin = new Padding(3), Text = text };
            button.FlatAppearance.BorderSize = 0;
            button.Click += (_, _) => ShowFeatureMessage(feature);
            return button;
        }

        private void ShowFeatureMessage(string feature)
        {
            MessageBox.Show($"{feature} is ready to be connected to the database module.", "QStudy Hub", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Dashboard_Load(object sender, EventArgs e) { }
        private void Dashboard_load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblname_Click(object sender, EventArgs e) { }
        private void pnlmain_Paint(object sender, PaintEventArgs e) { }
        private void btnmenu_Click(object sender, EventArgs e) { }
        private void sidebartimer_Tick(object sender, EventArgs e) { }

        private void btncourse_Click(object sender, EventArgs e)
        {
            if (Controls.Count == 0) return;
            MessageBox.Show("Courses are available from the existing course module.", "QStudy Hub", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncalendar_Click(object sender, EventArgs e)
        {
            using var calendar = new Calendar();
            calendar.ShowDialog(this);
        }

        private void btnhome_Click(object sender, EventArgs e) => BuildDashboard();

        private void btnExit_Click(object sender, EventArgs e) => Close();
    }
}