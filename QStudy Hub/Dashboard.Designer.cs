namespace QStudy_Hub
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            pnlnav = new Panel();
            btnExit = new Button();
            picboxstudimage = new PictureBox();
            btnhome = new Button();
            btncourse = new Button();
            lblname = new Label();
            btncalendar = new Button();
            pnluserinfo = new Panel();
            btnmenu = new Button();
            pnlmain = new Panel();
            label1 = new Label();
            pnlheader = new Panel();
            sidebartimer = new System.Windows.Forms.Timer(components);
            pnlnav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxstudimage).BeginInit();
            pnluserinfo.SuspendLayout();
            pnlmain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlnav
            // 
            pnlnav.BackColor = Color.FromArgb(70, 75, 113);
            pnlnav.Controls.Add(btnExit);
            pnlnav.Controls.Add(picboxstudimage);
            pnlnav.Controls.Add(btnhome);
            pnlnav.Controls.Add(btncourse);
            pnlnav.Controls.Add(lblname);
            pnlnav.Controls.Add(btncalendar);
            pnlnav.Controls.Add(pnluserinfo);
            pnlnav.Dock = DockStyle.Left;
            pnlnav.Location = new Point(0, 0);
            pnlnav.MaximumSize = new Size(227, 800);
            pnlnav.MinimumSize = new Size(67, 482);
            pnlnav.Name = "pnlnav";
            pnlnav.Size = new Size(227, 695);
            pnlnav.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImageLayout = ImageLayout.None;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 138, 178);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Leelawadee UI", 10F);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(21, 638);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(183, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "     Logout";
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // picboxstudimage
            // 
            picboxstudimage.BackColor = Color.Transparent;
            picboxstudimage.BackgroundImageLayout = ImageLayout.Center;
            picboxstudimage.ErrorImage = (Image)resources.GetObject("picboxstudimage.ErrorImage");
            picboxstudimage.Image = (Image)resources.GetObject("picboxstudimage.Image");
            picboxstudimage.InitialImage = (Image)resources.GetObject("picboxstudimage.InitialImage");
            picboxstudimage.Location = new Point(19, 78);
            picboxstudimage.Name = "picboxstudimage";
            picboxstudimage.Size = new Size(36, 34);
            picboxstudimage.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxstudimage.TabIndex = 3;
            picboxstudimage.TabStop = false;
            // 
            // btnhome
            // 
            btnhome.BackgroundImageLayout = ImageLayout.None;
            btnhome.FlatAppearance.BorderSize = 0;
            btnhome.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 138, 178);
            btnhome.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 138, 178);
            btnhome.FlatStyle = FlatStyle.Flat;
            btnhome.Font = new Font("Leelawadee UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnhome.ForeColor = Color.White;
            btnhome.Image = (Image)resources.GetObject("btnhome.Image");
            btnhome.ImageAlign = ContentAlignment.MiddleLeft;
            btnhome.Location = new Point(21, 143);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(183, 34);
            btnhome.TabIndex = 7;
            btnhome.Text = "     Home";
            btnhome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnhome.UseVisualStyleBackColor = true;
            btnhome.Click += btnhome_Click;
            // 
            // btncourse
            // 
            btncourse.BackgroundImageLayout = ImageLayout.None;
            btncourse.FlatAppearance.BorderSize = 0;
            btncourse.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 138, 178);
            btncourse.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 138, 178);
            btncourse.FlatStyle = FlatStyle.Flat;
            btncourse.Font = new Font("Leelawadee UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncourse.ForeColor = Color.White;
            btncourse.Image = (Image)resources.GetObject("btncourse.Image");
            btncourse.ImageAlign = ContentAlignment.MiddleLeft;
            btncourse.Location = new Point(21, 183);
            btncourse.Name = "btncourse";
            btncourse.Size = new Size(183, 34);
            btncourse.TabIndex = 3;
            btncourse.Text = "     Courses";
            btncourse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncourse.UseVisualStyleBackColor = true;
            btncourse.Click += btncourse_Click;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Century Schoolbook", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblname.ForeColor = Color.Transparent;
            lblname.Location = new Point(65, 87);
            lblname.Name = "lblname";
            lblname.Size = new Size(37, 15);
            lblname.TabIndex = 4;
            lblname.Text = "label2";
            lblname.TextAlign = ContentAlignment.MiddleLeft;
            lblname.Click += lblname_Click;
            // 
            // btncalendar
            // 
            btncalendar.FlatAppearance.BorderSize = 0;
            btncalendar.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 138, 178);
            btncalendar.FlatAppearance.MouseOverBackColor = Color.FromArgb(17, 138, 178);
            btncalendar.FlatStyle = FlatStyle.Flat;
            btncalendar.Font = new Font("Leelawadee UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncalendar.ForeColor = Color.White;
            btncalendar.Image = (Image)resources.GetObject("btncalendar.Image");
            btncalendar.ImageAlign = ContentAlignment.MiddleLeft;
            btncalendar.Location = new Point(21, 223);
            btncalendar.Name = "btncalendar";
            btncalendar.Size = new Size(183, 34);
            btncalendar.TabIndex = 4;
            btncalendar.Text = "     Calendar   ";
            btncalendar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncalendar.UseVisualStyleBackColor = true;
            btncalendar.Click += btncalendar_Click;
            // 
            // pnluserinfo
            // 
            pnluserinfo.BorderStyle = BorderStyle.FixedSingle;
            pnluserinfo.Controls.Add(btnmenu);
            pnluserinfo.Location = new Point(0, 0);
            pnluserinfo.Name = "pnluserinfo";
            pnluserinfo.Size = new Size(255, 69);
            pnluserinfo.TabIndex = 0;
            // 
            // btnmenu
            // 
            btnmenu.FlatAppearance.BorderSize = 0;
            btnmenu.FlatStyle = FlatStyle.Flat;
            btnmenu.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnmenu.ForeColor = Color.White;
            btnmenu.Image = (Image)resources.GetObject("btnmenu.Image");
            btnmenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnmenu.Location = new Point(20, 22);
            btnmenu.Name = "btnmenu";
            btnmenu.RightToLeft = RightToLeft.No;
            btnmenu.Size = new Size(88, 30);
            btnmenu.TabIndex = 0;
            btnmenu.Text = "     Menu";
            btnmenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // pnlmain
            // 
            pnlmain.BackColor = Color.FromArgb(242, 242, 237);
            pnlmain.Controls.Add(label1);
            pnlmain.Dock = DockStyle.Fill;
            pnlmain.Location = new Point(227, 0);
            pnlmain.Name = "pnlmain";
            pnlmain.Size = new Size(1057, 695);
            pnlmain.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(294, 162);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pnlheader
            // 
            pnlheader.BackColor = Color.White;
            pnlheader.Dock = DockStyle.Top;
            pnlheader.Location = new Point(227, 0);
            pnlheader.Name = "pnlheader";
            pnlheader.Size = new Size(1057, 41);
            pnlheader.TabIndex = 4;
            pnlheader.Paint += panel1_Paint;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 10;
            sidebartimer.Tick += sidebartimer_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1284, 695);
            Controls.Add(pnlheader);
            Controls.Add(pnlmain);
            Controls.Add(pnlnav);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QStudyHub";
            Load += Dashboard_Load;
            pnlnav.ResumeLayout(false);
            pnlnav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxstudimage).EndInit();
            pnluserinfo.ResumeLayout(false);
            pnlmain.ResumeLayout(false);
            pnlmain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlnav;
        private Panel pnlmain;
        private Button btncourse;
        private Button btncalendar;
        private Panel pnlheader;
        private Label lblname;
        private PictureBox picboxstudimage;
        private Button btnExit;
        private Panel pnluserinfo;
        private Button btnmenu;
        private Button btnhome;
        private Label label1;
        private System.Windows.Forms.Timer sidebartimer;
    }
}