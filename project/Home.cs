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
    public partial class Home : Form
    {
        public int Id { get; set; }
        public bool Loggedin { get; set; }
        public string LocationDel { get; set; }
        public Home()
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
                sidebar.Width -= 10;
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
                sidebar.Width += 10;
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
            DbManager db = new DbManager();
            if (Loggedin) MessageBox.Show($"Logged in as {db.SelectAccTypeById(this.Id)}");/*
            if(db.SelectCount("Retaurant") % 8 == 0)
            {
                for (int i = 0; i < db.SelectCount("Restaurant"); i++)
                {
                    db.SelectCountid_Restaurants(i, 1);

                }

            }*/
            //pictureBox1.Image = 
        }

        private void profile_Click(object sender, EventArgs e)
        {
            if(!Loggedin)
            {
                Login login = new Login();
                login.LocationDel = this.LocationDel;
                login.Loggedin = false;
                login.Show();
                this.Hide();

            }
            else
            {
                Profile profile = new Profile();
                profile.Id = this.Id;
            }
        }

        private void customerOrder_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Data);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplyDos applyDos = new ApplyDos();
            applyDos.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApplyPar applyPar = new ApplyPar();
            applyPar.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adminPanel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
