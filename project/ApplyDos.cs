﻿using System;
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
    public partial class ApplyDos : Form
    {
        public int Id { get; set; }
        public bool Loggedin { get; set; }
        public string LocationDel { get; set; }
        public ApplyDos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.LocationDel = this.LocationDel;
            home.Loggedin = this.Loggedin;
            home.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void avtobiografiq_Click(object sender, EventArgs e)
        {

        }

        private void motivaton_Click(object sender, EventArgs e)
        {

        }

        private void OtherDocuments_Click(object sender, EventArgs e)
        {

        }

        private void predaibtn_Click(object sender, EventArgs e)
        {

        }
    }
}
