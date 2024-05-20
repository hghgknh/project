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
    public partial class Resturant : Form
    {
        public int Id { get; set; }
        public bool Loggedin { get; set; }
        public string LocationDel {  get; set; }
        public int RestaurantId { get; set; }
        public List<string> Poruchka { get; set; }

        public Resturant()
        {
            InitializeComponent();
            btnfav.Visible = true;
            btnfaved.Visible = false;
        }

        private void Resturant_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"tekst da kajem za id -> {this.RestaurantId}", "tekst", MessageBoxButtons.OK);
            DbManager db = new DbManager();
            Restaurant restaurant = new Restaurant();
            restaurant = db.SelectRestaurant(RestaurantId);
            using (var ms = new System.IO.MemoryStream(restaurant.Restaurant_img))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
            label1.Text = restaurant.Restaurant_name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnfav_Click(object sender, EventArgs e)
        {
            btnfav.Visible = false;
            btnfaved.Visible = true;
        }

        private void btnfaved_Click(object sender, EventArgs e)
        {
            btnfav.Visible = true;
            btnfaved.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.LocationDel = this.LocationDel;
            home.Loggedin = this.Loggedin;
            home.Id = this.Id;
            home.Show();
            this.Close();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
