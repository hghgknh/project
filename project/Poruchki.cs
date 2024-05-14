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
    public partial class Poruchki : Form
    {
        public int Id { get; set; }
        public bool Loggedin { get; set; }
        public string LocationDel {  get; set; }
        public Poruchki()
        {
            InitializeComponent();
        }

        private void Poruchki_Load(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Id = this.Id;
            home.Loggedin = this.Loggedin;
            home.LocationDel = this.LocationDel;
            home.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
