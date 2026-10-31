namespace QStudy_Hub
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            txtfullname = new TextBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtemail = new TextBox();
            txtmobileno = new TextBox();
            pnlcontainer = new Panel();
            pictureBox1 = new PictureBox();
            btnsignin = new Button();
            btnclose = new Button();
            panel1 = new Panel();
            pnlfullname = new Panel();
            pbfullname = new PictureBox();
            pnl_fullname = new Panel();
            pnlusername = new Panel();
            pbusername = new PictureBox();
            pnl_username = new Panel();
            pnlemail = new Panel();
            pbemail = new PictureBox();
            pnl_email = new Panel();
            pnlpassword = new Panel();
            pbpassword = new PictureBox();
            pnl_password = new Panel();
            pnlnumber = new Panel();
            pbnumber = new PictureBox();
            pnl_number = new Panel();
            pnlcontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnlfullname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbfullname).BeginInit();
            pnlusername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbusername).BeginInit();
            pnlemail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbemail).BeginInit();
            pnlpassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbpassword).BeginInit();
            pnlnumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbnumber).BeginInit();
            SuspendLayout();
            // 
            // txtfullname
            // 
            txtfullname.BackColor = Color.FromArgb(242, 242, 237);
            txtfullname.BorderStyle = BorderStyle.None;
            txtfullname.Font = new Font("Segoe UI", 9.75F);
            txtfullname.Location = new Point(3, 4);
            txtfullname.Name = "txtfullname";
            txtfullname.PlaceholderText = "Full Name";
            txtfullname.Size = new Size(204, 18);
            txtfullname.TabIndex = 1;
            txtfullname.TextChanged += txtfullname_TextChanged;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.FromArgb(242, 242, 237);
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Segoe UI", 9.75F);
            txtusername.Location = new Point(3, 5);
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Username";
            txtusername.Size = new Size(204, 18);
            txtusername.TabIndex = 1;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.FromArgb(242, 242, 237);
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Segoe UI", 9.75F);
            txtpassword.Location = new Point(3, 5);
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(204, 18);
            txtpassword.TabIndex = 1;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.FromArgb(242, 242, 237);
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Font = new Font("Segoe UI", 9.75F);
            txtemail.Location = new Point(3, 4);
            txtemail.Name = "txtemail";
            txtemail.PlaceholderText = "Email";
            txtemail.Size = new Size(204, 18);
            txtemail.TabIndex = 1;
            // 
            // txtmobileno
            // 
            txtmobileno.BackColor = Color.FromArgb(242, 242, 237);
            txtmobileno.BorderStyle = BorderStyle.None;
            txtmobileno.Font = new Font("Segoe UI", 9.75F);
            txtmobileno.Location = new Point(3, 5);
            txtmobileno.Name = "txtmobileno";
            txtmobileno.PlaceholderText = "Mobile Number";
            txtmobileno.Size = new Size(204, 18);
            txtmobileno.TabIndex = 1;
            // 
            // pnlcontainer
            // 
            pnlcontainer.BackColor = Color.FromArgb(46, 63, 79);
            pnlcontainer.Controls.Add(pictureBox1);
            pnlcontainer.Location = new Point(115, 66);
            pnlcontainer.Name = "pnlcontainer";
            pnlcontainer.Size = new Size(304, 381);
            pnlcontainer.TabIndex = 10;
            pnlcontainer.Paint += pnlcontainer_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnsignin
            // 
            btnsignin.BackColor = Color.FromArgb(46, 63, 79);
            btnsignin.FlatAppearance.BorderSize = 0;
            btnsignin.FlatStyle = FlatStyle.Flat;
            btnsignin.ForeColor = Color.White;
            btnsignin.Location = new Point(472, 372);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(243, 23);
            btnsignin.TabIndex = 10;
            btnsignin.Text = "Register";
            btnsignin.UseVisualStyleBackColor = false;
            btnsignin.Click += btnsignin_Click;
            // 
            // btnclose
            // 
            btnclose.BackgroundImageLayout = ImageLayout.None;
            btnclose.Dock = DockStyle.Right;
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.ForeColor = Color.FromArgb(192, 0, 0);
            btnclose.Image = (Image)resources.GetObject("btnclose.Image");
            btnclose.Location = new Point(806, 0);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(41, 41);
            btnclose.TabIndex = 11;
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnclose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 41);
            panel1.TabIndex = 12;
            // 
            // pnlfullname
            // 
            pnlfullname.Controls.Add(pbfullname);
            pnlfullname.Controls.Add(pnl_fullname);
            pnlfullname.Controls.Add(txtfullname);
            pnlfullname.Location = new Point(472, 218);
            pnlfullname.Name = "pnlfullname";
            pnlfullname.Size = new Size(243, 34);
            pnlfullname.TabIndex = 2;
            // 
            // pbfullname
            // 
            pbfullname.Image = (Image)resources.GetObject("pbfullname.Image");
            pbfullname.Location = new Point(213, 4);
            pbfullname.Name = "pbfullname";
            pbfullname.Size = new Size(17, 17);
            pbfullname.SizeMode = PictureBoxSizeMode.Zoom;
            pbfullname.TabIndex = 19;
            pbfullname.TabStop = false;
            // 
            // pnl_fullname
            // 
            pnl_fullname.BackColor = Color.Black;
            pnl_fullname.Location = new Point(0, 25);
            pnl_fullname.Name = "pnl_fullname";
            pnl_fullname.Size = new Size(243, 3);
            pnl_fullname.TabIndex = 15;
            // 
            // pnlusername
            // 
            pnlusername.Controls.Add(pbusername);
            pnlusername.Controls.Add(pnl_username);
            pnlusername.Controls.Add(txtusername);
            pnlusername.Location = new Point(472, 114);
            pnlusername.Name = "pnlusername";
            pnlusername.Size = new Size(243, 34);
            pnlusername.TabIndex = 0;
            // 
            // pbusername
            // 
            pbusername.BackgroundImageLayout = ImageLayout.Stretch;
            pbusername.Image = (Image)resources.GetObject("pbusername.Image");
            pbusername.Location = new Point(213, 5);
            pbusername.Name = "pbusername";
            pbusername.Size = new Size(17, 17);
            pbusername.SizeMode = PictureBoxSizeMode.Zoom;
            pbusername.TabIndex = 19;
            pbusername.TabStop = false;
            // 
            // pnl_username
            // 
            pnl_username.BackColor = Color.Black;
            pnl_username.Location = new Point(0, 28);
            pnl_username.Name = "pnl_username";
            pnl_username.Size = new Size(243, 3);
            pnl_username.TabIndex = 1;
            // 
            // pnlemail
            // 
            pnlemail.Controls.Add(pbemail);
            pnlemail.Controls.Add(pnl_email);
            pnlemail.Controls.Add(txtemail);
            pnlemail.Location = new Point(472, 269);
            pnlemail.Name = "pnlemail";
            pnlemail.Size = new Size(243, 34);
            pnlemail.TabIndex = 3;
            // 
            // pbemail
            // 
            pbemail.Image = (Image)resources.GetObject("pbemail.Image");
            pbemail.Location = new Point(213, 5);
            pbemail.Name = "pbemail";
            pbemail.Size = new Size(17, 17);
            pbemail.SizeMode = PictureBoxSizeMode.Zoom;
            pbemail.TabIndex = 18;
            pbemail.TabStop = false;
            // 
            // pnl_email
            // 
            pnl_email.BackColor = Color.Black;
            pnl_email.Location = new Point(0, 28);
            pnl_email.Name = "pnl_email";
            pnl_email.Size = new Size(243, 3);
            pnl_email.TabIndex = 15;
            // 
            // pnlpassword
            // 
            pnlpassword.Controls.Add(pbpassword);
            pnlpassword.Controls.Add(pnl_password);
            pnlpassword.Controls.Add(txtpassword);
            pnlpassword.Location = new Point(472, 166);
            pnlpassword.Name = "pnlpassword";
            pnlpassword.Size = new Size(243, 34);
            pnlpassword.TabIndex = 1;
            // 
            // pbpassword
            // 
            pbpassword.Image = (Image)resources.GetObject("pbpassword.Image");
            pbpassword.Location = new Point(213, 5);
            pbpassword.Name = "pbpassword";
            pbpassword.Size = new Size(17, 17);
            pbpassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbpassword.TabIndex = 19;
            pbpassword.TabStop = false;
            // 
            // pnl_password
            // 
            pnl_password.BackColor = Color.Black;
            pnl_password.Location = new Point(0, 28);
            pnl_password.Name = "pnl_password";
            pnl_password.Size = new Size(243, 3);
            pnl_password.TabIndex = 15;
            // 
            // pnlnumber
            // 
            pnlnumber.Controls.Add(pbnumber);
            pnlnumber.Controls.Add(pnl_number);
            pnlnumber.Controls.Add(txtmobileno);
            pnlnumber.Location = new Point(472, 318);
            pnlnumber.Name = "pnlnumber";
            pnlnumber.Size = new Size(243, 34);
            pnlnumber.TabIndex = 4;
            // 
            // pbnumber
            // 
            pbnumber.Image = (Image)resources.GetObject("pbnumber.Image");
            pbnumber.Location = new Point(213, 5);
            pbnumber.Name = "pbnumber";
            pbnumber.Size = new Size(17, 17);
            pbnumber.SizeMode = PictureBoxSizeMode.Zoom;
            pbnumber.TabIndex = 19;
            pbnumber.TabStop = false;
            // 
            // pnl_number
            // 
            pnl_number.BackColor = Color.Black;
            pnl_number.Location = new Point(0, 28);
            pnl_number.Name = "pnl_number";
            pnl_number.Size = new Size(243, 3);
            pnl_number.TabIndex = 15;
            // 
            // Signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 237);
            ClientSize = new Size(847, 482);
            Controls.Add(btnsignin);
            Controls.Add(pnlnumber);
            Controls.Add(pnlpassword);
            Controls.Add(pnlemail);
            Controls.Add(pnlusername);
            Controls.Add(pnlfullname);
            Controls.Add(panel1);
            Controls.Add(pnlcontainer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Signin";
            Load += Signin_Load;
            pnlcontainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            pnlfullname.ResumeLayout(false);
            pnlfullname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbfullname).EndInit();
            pnlusername.ResumeLayout(false);
            pnlusername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbusername).EndInit();
            pnlemail.ResumeLayout(false);
            pnlemail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbemail).EndInit();
            pnlpassword.ResumeLayout(false);
            pnlpassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbpassword).EndInit();
            pnlnumber.ResumeLayout(false);
            pnlnumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbnumber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtfullname;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtemail;
        private TextBox txtmobileno;
        private Panel pnlcontainer;
        private Button btnclose;
        private Panel panel1;
        private Panel pnlfullname;
        private Panel pnlusername;
        private Panel pnl_fullname;
        private Panel pnl_username;
        private Panel pnlemail;
        private Panel pnl_email;
        private Panel pnlpassword;
        private Panel pnl_password;
        private Panel pnlnumber;
        private Panel pnl_number;
        private PictureBox pbfullname;
        private PictureBox pbusername;
        private PictureBox pbemail;
        private PictureBox pbpassword;
        private PictureBox pbnumber;
        private Button btnsignin;
        private PictureBox pictureBox1;
    }
}