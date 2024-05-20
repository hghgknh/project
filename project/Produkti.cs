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
        public string img_path;
        public int Id { get; set; }
        public bool Loggedin { get; set; }
        public string LocationDel { get; set; }
        public int RestaurantID { get; set; }
        private bool imgr = false;
        public Produkti()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            LoadRestaurantFood();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            if(textBox3.Text != null && textBox1.Text != null && textBox2.Text != null && imgr)
            {
                int x = db.InsertFood(this.img_path, textBox2.Text, textBox3.Text, int.Parse(textBox1.Text));
                MessageBox.Show($"ooo {x}", "ooooo", MessageBoxButtons.OK);
                db.InsertRestFood(this.Id, x);
            }
        }
        private void LoadRestaurantFood()
        {
            DbManager db = new DbManager();
            DataTable dt = db.SelectRestaurantFood(this.RestaurantID);
            dataGridView1.DataSource = dt;
        }

        private void Produkti_Load(object sender, EventArgs e)
        {
            LoadRestaurantFood();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DbManager db = new DbManager();
            //dataGridView1.DataSource = db.SelectRestaurantFood(RestaurantID);
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Изберете файл";
            openFile.InitialDirectory = @"C:\";
            openFile.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            openFile.ShowDialog();
            if (!string.IsNullOrEmpty(openFile.FileName))
            {
                img_path = openFile.FileName;
                MessageBox.Show("nekaf tihekst", $"durugutu tihekst s oshte neshtu {img_path}", MessageBoxButtons.OK);
                pictureBox1.BackgroundImage = Image.FromFile(img_path);
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                imgr = true;
            }
            else img_path = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            db.DeleteFood((int)dataGridView1.CurrentRow.Cells[0].Value);
            //db.SelectFood(this.Id);
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point lastPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }
    }
}
