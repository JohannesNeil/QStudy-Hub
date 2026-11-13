using System.Runtime.InteropServices;

namespace QStudy_Hub
{
    public partial class Login : Form
    {
        private readonly AuthenticationService authenticationService = new();

        public Login()
        {
            InitializeComponent();
            txtpass.UseSystemPasswordChar = true;
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

        private void btnExit_Click(object sender, EventArgs e) //Exit Button
        {
            this.Close();
        }

        private void btnsignin_Click(object sender, EventArgs e) //Direct to Signin form
        {
            this.Hide();
            Signin sn = new Signin();
            sn.ShowDialog();
            this.Close();
        }

    }
}
