namespace project
{
    partial class Restaurants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurants));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.customerOrder = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(10, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 37);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // minimize
            // 
            this.minimize.Location = new System.Drawing.Point(679, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(54, 37);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "__";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(739, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(54, 37);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 26);
            this.dataGridView1.TabIndex = 6;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.sidebar.Controls.Add(this.profile);
            this.sidebar.Controls.Add(this.customerOrder);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Controls.Add(this.adminPanel);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 43);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(240, 407);
            this.sidebar.TabIndex = 8;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // customerOrder
            // 
            this.customerOrder.Location = new System.Drawing.Point(3, 55);
            this.customerOrder.Name = "customerOrder";
            this.customerOrder.Size = new System.Drawing.Size(232, 46);
            this.customerOrder.TabIndex = 10;
            this.customerOrder.Text = "Поръчки";
            this.customerOrder.UseVisualStyleBackColor = true;
            // 
            // profile
            // 
            this.profile.Location = new System.Drawing.Point(3, 3);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(232, 46);
            this.profile.TabIndex = 9;
            this.profile.Text = "Профил";
            this.profile.UseVisualStyleBackColor = true;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 46);
            this.button2.TabIndex = 14;
            this.button2.Text = "Любими ресторант";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "Любими храни";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Стани доставчик";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 46);
            this.button4.TabIndex = 12;
            this.button4.Text = "Стани бизнес партньор";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // adminPanel
            // 
            this.adminPanel.Location = new System.Drawing.Point(3, 315);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(232, 46);
            this.adminPanel.TabIndex = 15;
            this.adminPanel.Text = "Администрация";
            this.adminPanel.UseVisualStyleBackColor = true;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(793, 346);
            this.dataGridView2.TabIndex = 9;
            // 
            // Restaurants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Restaurants";
            this.Text = "Restaurants";
            this.Load += new System.EventHandler(this.Restaurants_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button customerOrder;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adminPanel;
    }
}