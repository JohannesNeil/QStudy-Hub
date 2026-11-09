using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QStudy_Hub
{
    public partial class Signin : Form
    {
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

        //For successful signin, still needs database connection 
        private void btnsignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            lgn.ShowDialog();
            this.Close();
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