namespace QStudy_Hub
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtusername = new TextBox();
            txtpass = new TextBox();
            btnlogin = new Button();
            btnsignin = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(3, 3);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Name / Email / Mobile Number";
            txtusername.Size = new Size(204, 18);
            txtusername.TabIndex = 0;
            // 
            // txtpass
            // 
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Location = new Point(3, 3);
            txtpass.Name = "txtpass";
            txtpass.PlaceholderText = "Password";
            txtpass.Size = new Size(204, 18);
            txtpass.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(70, 75, 113);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(59, 300);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(243, 26);
            btnlogin.TabIndex = 2;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnsignin
            // 
            btnsignin.BackColor = Color.Transparent;
            btnsignin.FlatAppearance.BorderSize = 0;
            btnsignin.FlatStyle = FlatStyle.Flat;
            btnsignin.Font = new Font("Segoe UI Emoji", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsignin.ForeColor = Color.FromArgb(48, 175, 255);
            btnsignin.Location = new Point(191, 332);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(65, 24);
            btnsignin.TabIndex = 3;
            btnsignin.Text = "Sign In";
            btnsignin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(70, 75, 113);
            label2.Location = new Point(98, 159);
            label2.Name = "label2";
            label2.Size = new Size(168, 27);
            label2.TabIndex = 7;
            label2.Text = "Welcome Back!";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txtusername);
            panel1.Location = new Point(59, 203);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 34);
            panel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(213, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(17, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(txtpass);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(59, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 34);
            panel2.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(213, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(17, 17);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(0, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 3);
            panel3.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 337);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 11;
            label3.Text = "No Account Yet?";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(59, 227);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 3);
            panel4.TabIndex = 11;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Emoji", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(315, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(32, 31);
            btnExit.TabIndex = 12;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(359, 444);
            Controls.Add(btnExit);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(btnlogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnsignin);
            Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QStudyHub";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtpass;
        private Button btnlogin;
        private Button btnsignin;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Button btnExit;
    }
}
