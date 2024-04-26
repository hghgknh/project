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
    public partial class Location : Form
    {
        public int Id { get; set; }
        public bool Loggedin { get; set; }
        public string LocationDel {  get; set; }
        //public static Account entAcc;
        //public string Adress;
        public Location()
        {
            InitializeComponent();
        }
        Point lastPoint;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Loggedin)
            {
                DbManager db = new DbManager();
                db.UpdateAccLocation(this.Id, textBox1.Text);
                //Adress = textBox1.Text;
                //Account account = new Account();
                Home restaurants = new Home();
                restaurants.Id = this.Id;
                restaurants.Loggedin = true;
                restaurants.LocationDel = textBox1.Text;
                restaurants.Show();
                this.Hide();
            }
            else
            {
                Home home = new Home();
                home.Loggedin = false;
                home.LocationDel = textBox1.Text;
                home.Show();
                this.Hide();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

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

        private void Location_Load(object sender, EventArgs e)
        {
            if(LocationDel != null)
            {
                textBox1.Text = LocationDel;
            }
            else
            {
                textBox1.Text = "";

            }
        }
    }
}
