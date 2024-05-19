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
        public int Id { get; set; }
        public bool Loggedin { get; set; }
        public string LocationDel { get; set; }
        public List<string> Poruchka { get; set; }
        public Home()
        {
            InitializeComponent();
        }
        Point lastPoint;
        //bool menuExpand = false;
        //bool panelExpand = false;

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

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool sidebarExpand = true;

        bool panelExpand = true;
        bool panel1Expand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) {
                sidebar.Width -= 10;
                if (sidebar.Width <= 0) {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 240) {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                }
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
            //buttonTransition.Start();
            //button1Transition.Start();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Restaurants_Load(object sender, EventArgs e)
        {
            /*this.Poruchka = new List<string>();
            this.Poruchka.Add("ammiiii1");
            this.Poruchka.Add("ammiiii3");
            this.Poruchka.Add("ammiiii6");
            this.Poruchka.Add("ammiiii4");
            this.Poruchka.Add("ammiiii2");*/

            sidebarTransition.Start();
            DbManager db = new DbManager();
            if (Loggedin)
            {
                MessageBox.Show($"Logged in as {db.SelectAccTypeById(this.Id)}");
                if(db.SelectAccTypeById(this.Id) == "admin")
                {
                    button3.Visible = true;
                    button4.Visible = true;
                    profile.Visible = false;
                    customerOrder.Visible = true;
                }
                else if (db.SelectAccTypeById(this.Id) == "par")
                {
                    button3.Visible = true;
                    button4.Visible = false;
                    profile.Visible = true;
                    customerOrder.Visible = true;
                }
                else if (db.SelectAccTypeById(this.Id) == "dos")
                {
                    button3.Visible = true;
                    button4.Visible = false;
                    profile.Visible = true;
                    customerOrder.Visible = true;
                }
                else if (db.SelectAccTypeById(this.Id) == "customer")
                {
                    button3.Visible = true;
                    button4.Visible = false;
                    profile.Visible = true;
                    customerOrder.Visible = true;
                }
            }
            if (db.sele)


            /*
            if(db.SelectCount("Retaurant") % 8 == 0)
            {
                for (int i = 0; i < db.SelectCount("Restaurant"); i++)
                {
                    db.SelectCountid_Restaurants(i, 1);

                }

            }*/
            //pictureBox1.Image = 
            //button1.Visible = false;
            //button2.Visible = false;
        }

        private void profile_Click(object sender, EventArgs e)
        {
            if(!Loggedin)
            {
                Login login = new Login();
                login.LocationDel = this.LocationDel;
                login.Loggedin = false;
                login.Show();
                this.Hide();

            }
            else
            {
                Profile profile = new Profile();
                profile.Id = this.Id;
                profile.Show();
                this.Close();
            }
        }

        private void customerOrder_Click(object sender, EventArgs e)
        {
            Poruchki poruchki = new Poruchki();
            poruchki.Poruchka = this.Poruchka;
            poruchki.LocationDel = this.LocationDel;
            poruchki.Loggedin = this.Loggedin;
            poruchki.Id = this.Id;
            poruchki.Show();
            this.Hide();
            //MessageBox.Show(Data);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplyDos applyDos = new ApplyDos();
            applyDos.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApplyPar applyPar = new ApplyPar();
            applyPar.LocationDel = this.LocationDel;
            applyPar.Loggedin = this.Loggedin;
            applyPar.Id = this.Id;
            applyPar.Show();
            this.Hide();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adminPanel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Resturant resturant = new Resturant();
            resturant.Id = this.Id;
            resturant.Loggedin = this.Loggedin;
            resturant.LocationDel = this.LocationDel;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
