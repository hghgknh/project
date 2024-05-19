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
    public partial class Login : Form
    {
        private bool hasBeenClicked = false;
        private bool passwordTyped = false;
        public int Id { get; set; }
        public bool Loggedin {  get; set; }
        public string LocationDel {  get; set; }

        //public static Account entAcc;
        public Login()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
        }
        Point lastPoint;

        private void label2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.LocationDel = this.LocationDel;
            register.Show();
            this.Close();
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

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.LocationDel = this.LocationDel;
            home.Loggedin = false;
            home.Show();
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (!hasBeenClicked || textBox1.Text == "Потребителско име")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox1.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Потребителско име";
                hasBeenClicked = false;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox1.Text == "Парола")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox1.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Парола";
                hasBeenClicked = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox box = sender as TextBox;
            if (!string.IsNullOrEmpty(box.Text) && box.Text != "Парола")
            {
                passwordTyped = true;
                box.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTyped = false;
                box.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            if (db.SelectAccExist(textBox1.Text, textBox2.Text))
            {
                Home home = new Home();
                home.Id = db.SelectAccIdByUsername(textBox1.Text);
                home.Loggedin = true;
                home.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Влезте в акаунт");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            if (!Loggedin)
            {
                MessageBox.Show("Не сте влезли в акаунт");
            }
            else
            {
                Profile profile = new Profile();
                profile.Id = this.Id;
                this.Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
