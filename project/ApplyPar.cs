using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

        public int Id { get; set; }
        public bool Loggedin { get; set; }
        public string LocationDel { get; set; }
        public ApplyPar()
        {
            InitializeComponent();
        }

        private void ApplyPar_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            if(Loggedin){
                if(db.SelectAccTypeById(this.Id) == "par")
                {
                    Produkti produkti = new Produkti();
                    produkti.LocationDel = this.LocationDel;
                    produkti.Loggedin = this.Loggedin;
                    produkti.Id = this.Id;
                    produkti.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Как?", "Въпрос", MessageBoxButtons.OK);
                }
            }
            else{
                pnlUser.Visible = false;
                pnlRestInfo.Visible = false;
                pnlInfo.Visible = true;
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.img_path != null && textBox1.Text != null && textBox2.Text != null)
            {
                panel2_complete = true;
            }
            else
            {
                panel2_complete = false;
                MessageBox.Show("Не всички данни са попълнени.", "Грешка при данните", MessageBoxButtons.OK);
            }


            if (panel1_complete && panel2_complete)
            {
                DbManager db = new DbManager();
                Account account = new Account();
                account.Name = FirstName.Text;
                account.Password = EGN.Text;
                account.Email = email.Text;
                account.Location = textBox2.Text;
                account.Phone_num = telNomer.Text;
                account.Type = "par";
                db.InsertAcc(account);
                db.InsertImage(this.img_path, textBox1.Text, textBox2.Text, db.SelectAccIdByUsername(account.Name));
            }
            else
            {
                pnlRestInfo.Visible = true;
                pnlUser.Visible = false;
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

        private void NazadMenu_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
            pnlRestInfo.Visible = false;
            pnlInfo.Visible = true;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = true;
            pnlRestInfo.Visible = false;
            pnlInfo.Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.LocationDel = this.LocationDel;
            home.Loggedin = this.Loggedin;
            home.Show();
            this.Close();
        }

        private void btnConfirmPRF_Click(object sender, EventArgs e)
        {
            if(EGN.Text == adres2.Text)
            {
                if (FirstName.Text != null && telNomer.Text != null && adres1.Text != null && email.Text != null && EGN.Text != null && adres2.Text != null)
                {
                    panel1_complete = true;
                }
                else
                {
                    MessageBox.Show("Не всички данни са попълнени.", "Грешка при данните", MessageBoxButtons.OK);
                    panel1_complete = false;
                }
            }
            else
            {
                MessageBox.Show("Паролите не съвпадат.", "Грешка при данните", MessageBoxButtons.OK);
                panel1_complete = false;
            }

            if (panel1_complete && panel2_complete)
            {
                DbManager db = new DbManager();
                Account account = new Account();
                account.Name = FirstName.Text;
                account.Password = EGN.Text;
                account.Email = email.Text;
                account.Location = textBox2.Text;
                account.Phone_num = telNomer.Text;
                account.Type = "par";
                db.InsertAcc(account);
                db.InsertImage(this.img_path, textBox1.Text, textBox2.Text, db.SelectAccIdByUsername(account.Name));
            }
            else
            {
                pnlRestInfo.Visible = false;
                pnlUser.Visible = true;
            }
        }

        Point lastPoint;
        private void pnlzabackbtn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }
        private void pnlzabackbtn_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void Kandidatura_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }
        private void Kandidatura_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            }
            else img_path = string.Empty;
        }
    }
}
