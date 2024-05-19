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
    public partial class Profile : Form
    {
        public int Id { get; set; }
        public Profile()
        {
            InitializeComponent();
        }
        Point lastPoint;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Id = this.Id;
            home.Loggedin = true;
            home.Show();
            this.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            Account account = db.SelectPerAcc(this.Id);
            textBox1.Text = account.Name;
            textBox2.Text = account.Password;
            textBox3.Text = account.Email;
            textBox4.Text = account.Location;
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            Account account = new Account();
            account.Id = this.Id;
            account.Name = textBox1.Text;
            account.Password = textBox2.Text;
            account.Email = textBox3.Text;
            account.Location = textBox4.Text;
            if (db.UpdateAcc(account)) MessageBox.Show("Akaunta e udejtnat", "Update complete", MessageBoxButtons.OK);
            else MessageBox.Show("Ima greshka", "akaunta ne e updejtnat uspeshno", MessageBoxButtons.OK);
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

        private void Profil_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Profil_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
