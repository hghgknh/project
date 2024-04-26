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
    public partial class Produkti : Form
    {
        public int RestaurantID { get; set; }
        public Produkti()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox3 != null)
            {

            }
        }

        private void Produkti_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectRestaurantFood(RestaurantID);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectRestaurantFood(RestaurantID);
        }
    }
}
