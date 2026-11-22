using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QStudy_Hub
{
    public partial class Login : Form
    {
        private readonly AuthenticationService authenticationService = new();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Login()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
        }
        private void ApplyPanelRounding() // Custom panel edges
        {
            if (pnlLogin.Width > 0 && pnlLogin.Height > 0)
            {
                pnlLogin.Region = Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, pnlLogin.Width, pnlLogin.Height, 30, 30)
                );
            }

        }

        private async void btnlogin_Click(object sender, EventArgs e)
        {
            var emailOrUsername = txtusername.Text.Trim();
            var password = txtpass.Text;

            if (string.IsNullOrWhiteSpace(emailOrUsername) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter your email or username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnlogin.Enabled = false;
                var user = await authenticationService.LoginAsync(emailOrUsername, password);

                if (user is null)
                {
                    MessageBox.Show("Invalid email/username or password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Hide();
                using (var dashboard = new Dashboard(user.Username))
                {
                    dashboard.ShowDialog();
                }
                Close();
            }
            catch (MySqlConnector.MySqlException exception)
            {
                MessageBox.Show(DatabaseSettings.DescribeConnectionError(exception), "Database connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnlogin.Enabled = true;
            }
        }

        private void btnsignin_Click(object sender, EventArgs e) //Direct to Signin form
        {
            this.Hide();
            Signin sn = new Signin();
            sn.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ApplyPanelRounding(); // Add Rounded Corners to the panel
        }
    }
}
