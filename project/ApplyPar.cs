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
    public partial class ApplyPar : Form
    {
        public ApplyPar()
        {
            InitializeComponent();
        }

        private void ApplyPar_Load(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
            pnlRestInfo.Visible = false;
            pnlInfo.Visible = true;
        }

        private void pnlzabackbtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
            pnlRestInfo.Visible = true;
            pnlInfo.Visible = false;
        }

        private void napredRest_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = true;
            pnlRestInfo.Visible = false;
            pnlInfo.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
            pnlRestInfo.Visible = true;
            pnlInfo.Visible = false;
        }
    }
}
