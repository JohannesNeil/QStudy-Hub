using System.Runtime.InteropServices;

namespace QStudy_Hub
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
         int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
         int nWidthEllipse, int nHeightEllipse
         );



        public Login()
        {
            InitializeComponent();
            //Rounded Form Code
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = "Johannes Neil Sustitudo";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //private void label2_Click(object sender, EventArgs e)
        //{

        //}
    }
}
