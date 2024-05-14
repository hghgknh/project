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

        public Resturant()
        {
            InitializeComponent();
            btnfav.Visible = true;
            btnfaved.Visible = false;
        }

        private void Resturant_Load(object sender, EventArgs e)
        {

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
    }
}
