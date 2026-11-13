using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QStudy_Hub
{
    public partial class Signin : Form
    {
        private readonly AuthenticationService authenticationService = new();

        // Import Win32 GDI32 DLL for rounded edges
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Signin()
        {
            InitializeComponent();
            txtpassword.UseSystemPasswordChar = true;
        }

        private void ApplyPanelRounding()
        {
            // Custom rounded panel edges
            if (pnlcontainer.Width > 0 && pnlcontainer.Height > 0)
            {
                pnlcontainer.Region = Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, pnlcontainer.Width, pnlcontainer.Height, 30, 30)
                );
            }

        }

        private void Signin_Load(object sender, EventArgs e)
        {
            ApplyPanelRounding();
        }

        // Auto reapply rounding for possible size changes
        private void pnlcontainer_SizeChanged(object sender, EventArgs e)
        {
            ApplyPanelRounding();
        }

        //Direct back to login form
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            lgn.ShowDialog();
            this.Close();
        }

        private async void btnsignin_Click(object sender, EventArgs e)
        {
            var fullName = txtfullname.Text.Trim();
            var username = txtusername.Text.Trim();
            var email = txtemail.Text.Trim().ToLowerInvariant();
            var password = txtpassword.Text;

            if (string.IsNullOrWhiteSpace(fullName) || fullName.Length > 120)
            {
                MessageBox.Show("Enter a valid full name.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(username, "^[A-Za-z0-9_]{3,50}$"))
            {
                MessageBox.Show("Username must be 3-50 letters, numbers, or underscores.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, "^[^@\\s]+@[^@\\s]+\\.[^@\\s]+$"))
            {
                MessageBox.Show("Enter a valid email address.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnsignin.Enabled = false;
                var result = await authenticationService.RegisterAsync(fullName, email, username, password);

                switch (result)
                {
                    case RegistrationResult.DuplicateEmail:
                        MessageBox.Show("That email address is already registered.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    case RegistrationResult.DuplicateUsername:
                        MessageBox.Show("That username is already taken.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    default:
                        MessageBox.Show("Account created successfully. You can now log in.", "Sign up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Hide();
                        using (var login = new Login())
                        {
                            login.ShowDialog();
                        }
                        Close();
                        return;
                }
            }
            catch (MySqlConnector.MySqlException exception)
            {
                MessageBox.Show(DatabaseSettings.DescribeConnectionError(exception), "Database connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnsignin.Enabled = true;
            }
        }

        //Wag mo nalang pansinin nadouble click langs :)
        private void pnlcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}