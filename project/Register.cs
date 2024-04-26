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
    public partial class Register : Form
    {
        public string LocationDel {  get; set; }
        //public int Id { get; set; }
        //public bool Loggedin { get; set; }
        public Register()
        {
            InitializeComponent();
        }
        Point lastPoint;
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

        private void back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Loggedin = false;
            login.LocationDel = this.LocationDel;
            login.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            Account account = new Account();
            if (db.SearchForName(textBox1.Text))
            {
                account.Name = textBox1.Text;
            }
            else
            {
                MessageBox.Show("tuk ne vliza?", "aaaaaa Exit", MessageBoxButtons.OK);
                account.Name = null;
            }
            if (textBox2.Text == textBox3.Text)
            {
                account.Password = textBox2.Text;
            }
            else
            {
                MessageBox.Show("Are you sure you want to exit?", "bbbbbb Exit", MessageBoxButtons.OK);
                account.Password = null;
            }
            account.Email = textBox4.Text;
            account.Location = textBox5.Text;
            account.Phone_num = textBox6.Text;
            account.Type = "customer";
            if (account.Name != null && account.Password != null && account.Email != null && account.Location != null)
            {
                db.InsertAcc(account);
                Login login = new Login();
                login.Loggedin = false;
                login.LocationDel = this.LocationDel;
                login.Show();
                this.Hide();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBox5.Text = this.LocationDel;
        }
    }
}
