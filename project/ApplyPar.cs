using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class ApplyPar : Form
    {
        public string img_path;
        private bool panel1_complete = false;
        private bool panel2_complete = false;
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
        private void btnsnimkiRest_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Изберете файл";
            openFile.InitialDirectory = @"C:\";
            openFile.Filter = "All files (*.*) |*.*| DataBase file (*.db*)|*.db";
            openFile.ShowDialog();
            if (!string.IsNullOrEmpty(openFile.FileName))
            {
                img_path = openFile.FileName;
                MessageBox.Show("nekaf tihekst", $"durugutu tihekst s oshte neshtu {img_path}", MessageBoxButtons.OK);
                using (Stream s = File.Open(img_path, FileMode.Create))
                {
                    btnsnimkiRest.Image.Save(s, System.Drawing.Imaging.ImageFormat.MemoryBmp);
                }
            }
            else img_path = string.Empty;
            /*
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "IMG files (*.img)|*.img"; // set the file filter to.img files
            saveFileDialog1.DefaultExt = "img"; // set the default file extension to.img

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                {
                    btnsnimkiRest.Image.Save(s, System.Drawing.Imaging.ImageFormat.MemoryBmp);
                }
            }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.img_path != null && textBox1.Text != null && textBox2.Text != null)
            {
                DbManager db = new DbManager();
                db.InsertImage(this.img_path, textBox1.Text, textBox2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
