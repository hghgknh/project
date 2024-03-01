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
        public string Adress;
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adress = textBox1.Text;
        }
    }
}
