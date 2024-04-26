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
            db.SelectPerAcc(Id);
        }
    }
}
