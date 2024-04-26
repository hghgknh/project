using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Restaurants : Form
    {
        public string Data { get; set; }
        public Restaurants()
        {
            InitializeComponent();
        }
        Point lastPoint;
        bool menuExpand = false;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) {
                sidebar.Width -= 5;
                if (sidebar.Width <= 0) {
                    sidebarExpand = false;
                    sidebarTransition.Stop();/*
                    button1.Width = sidebar.Width;
                    button2.Width = sidebar.Width;
                    button3.Width = sidebar.Width;
                    button4.Width = sidebar.Width;*/
                }
            }else
            {
                sidebar.Width += 5;
                if(sidebar.Width >= 240) {
                    sidebarExpand = true;
                    sidebarTransition.Stop();/*
                    button1.Width = sidebar.Width;
                    button2.Width = sidebar.Width;
                    button3.Width = sidebar.Width;
                    button4.Width = sidebar.Width;*/
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Restaurants_Load(object sender, EventArgs e)
        {
            sidebar.Width = 0;
        }

        private void profile_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void customerOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Data);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
