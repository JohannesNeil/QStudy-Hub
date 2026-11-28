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
            panel1 = new Panel();
            panel6 = new Panel();
            pbusername = new PictureBox();
            panel2 = new Panel();
            pbpassword = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            pnlLogin = new Panel();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbusername).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbpassword).BeginInit();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            btnlogin.BackColor = Color.FromArgb(46, 63, 79);
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(29, 288);
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
            btnsignin.ForeColor = Color.FromArgb(46, 63, 79);
            btnsignin.Location = new Point(171, 327);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(65, 24);
            btnsignin.TabIndex = 3;
            btnsignin.Text = "Sign In";
            btnsignin.UseVisualStyleBackColor = false;
            btnsignin.Click += btnsignin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(pbusername);
            panel1.Controls.Add(txtusername);
            panel1.Location = new Point(29, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 34);
            panel1.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(0, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(243, 1);
            panel6.TabIndex = 11;
            // 
            // pbusername
            // 
            pbusername.BackColor = Color.Transparent;
            pbusername.Image = (Image)resources.GetObject("pbusername.Image");
            pbusername.Location = new Point(213, 3);
            pbusername.Name = "pbusername";
            pbusername.Size = new Size(17, 17);
            pbusername.SizeMode = PictureBoxSizeMode.Zoom;
            pbusername.TabIndex = 10;
            pbusername.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbpassword);
            panel2.Controls.Add(txtpass);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(29, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 34);
            panel2.TabIndex = 9;
            // 
            // pbpassword
            // 
            pbpassword.BackColor = Color.Transparent;
            pbpassword.Image = (Image)resources.GetObject("pbpassword.Image");
            pbpassword.Location = new Point(213, 4);
            pbpassword.Name = "pbpassword";
            pbpassword.Size = new Size(17, 17);
            pbpassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbpassword.TabIndex = 10;
            pbpassword.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(0, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 1);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(29, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(243, 3);
            panel4.TabIndex = 11;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(btnsignin);
            pnlLogin.Controls.Add(panel1);
            pnlLogin.Controls.Add(panel2);
            pnlLogin.Controls.Add(panel4);
            pnlLogin.Controls.Add(btnlogin);
            pnlLogin.Controls.Add(pictureBox4);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Location = new Point(257, 49);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(304, 381);
            pnlLogin.TabIndex = 13;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-52, -124);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(416, 443);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 7F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 332);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 11;
            label1.Text = "Don't have an account yet?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(242, 242, 237);
            ClientSize = new Size(847, 482);
            Controls.Add(pnlLogin);
            Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QStudyHub";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbusername).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbpassword).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtpass;
        private Button btnlogin;
        private Button btnsignin;
        private Panel panel1;
        private PictureBox pbusername;
        private Panel panel2;
        private PictureBox pbpassword;
        private Panel panel3;
        private Panel panel4;
        private Panel pnlLogin;
        private PictureBox pictureBox4;
        private Label label1;
        private Panel panel6;
    }
}
