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
        //In case of rounded corners for the form
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
            lblname.Text = username;

            InitializeNavigationControl();
        }

        private void InitializeNavigationControl()
        {
            pnlmain.Controls.Clear();
            UC_Home control = new UC_Home(); // Using the user control for home page
            control.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(control);

        }

        private void loadView(UserControl uc) // Method to load the user control into the main panel
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
            UC_Courses control = new UC_Courses(); //Using the user control for courses page
            control.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(control);
        }

        private void btncalendar_Click(object sender, EventArgs e)
        {
            pnlmain.Controls.Clear();
            UC_Calendar control = new UC_Calendar();// Using the user control for calendar page
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
            UC_Home control = new UC_Home(); // Using the user control for home page
            control.Dock = DockStyle.Fill;
            pnlmain.Controls.Add(control);

        }

        private void sidebartimer_Tick(object sender, EventArgs e) // Animation of the sidebar when Menu is clicked
        {
            if (sidebarExpand)
            {
                pnlnav.Width -= 15; // Adjust speed of the sidebar animation

                if (pnlnav.Width <= pnlnav.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                pnlnav.Width += 15; // Adjust speed of the sidebar animation

                if (pnlnav.Width >= pnlnav.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void btnmenu_Click(object sender, EventArgs e) //Sidebar menu button
        {
            sidebartimer.Start();
        }
    }
}
