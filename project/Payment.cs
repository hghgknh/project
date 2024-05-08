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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            panel_card.Visible = false;
            panel_method.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Потвърдено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_card.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Display a message box with the text "Потвърдено"
            MessageBox.Show("Потвърдено");
            panel_card.Visible = false;
            panel_method.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_card.Visible = false;
            panel_method.Visible = true;
        }
    }
}
