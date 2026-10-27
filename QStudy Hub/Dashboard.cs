using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using QStudy_Hub.User_Controls;
using System.Runtime.InteropServices;


namespace QStudy_Hub
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
         int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
         int nWidthEllipse, int nHeightEllipse
        );

        bool sidebarExpand;

        NavigationControl navigationControl;
        public Dashboard(string username)
        {
            InitializeComponent();
            //Rounded Form Code
            //this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            lblname.Text = username;

            InitializeNavigationControl();
        }

        private void InitializeNavigationControl()
        {
            pnlmain.Controls.Clear();
            UC_Home control = new UC_Home();
            control.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(control);

            //List<UserControl> userControl = new List<UserControl>()
            //{ new UC_Courses(), new UC_Calendar()};

            //navigationControl = new NavigationControl(userControl, pnlmain);
        }

        private void loadView(UserControl uc)
        {
            pnlmain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(uc);
            uc.BringToFront();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btncourse_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            UC_Courses control = new UC_Courses();
            control.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(control);
        }

        private void btncalendar_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            UC_Calendar control = new UC_Calendar();
            control.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(control);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_load(object sender, EventArgs e)
        {
            loadView(new User_Controls.UC_Home());
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            UC_Home control = new UC_Home();
            control.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(control);

        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                pnlnav.Width -= 15;

                if (pnlnav.Width <= pnlnav.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                pnlnav.Width += 15;

                if (pnlnav.Width >= pnlnav.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }
    }
}
