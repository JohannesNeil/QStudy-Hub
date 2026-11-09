using System.Runtime.InteropServices;

namespace QStudy_Hub
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //Use for test login credentials
            //Change with database connection later
            string username = "username";
            string pass = "pass";

            if (username == txtusername.Text && pass == txtpass.Text)
            {
                this.Hide();
                Dashboard db = new Dashboard(username);
                db.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
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
