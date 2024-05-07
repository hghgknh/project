namespace project
{
    partial class Profile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Profil = new System.Windows.Forms.Label();
            this.minbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.Profil);
            this.panel1.Controls.Add(this.minbtn);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Controls.Add(this.backbtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 48);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Profil
            // 
            this.Profil.AutoSize = true;
            this.Profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Profil.Location = new System.Drawing.Point(363, 9);
            this.Profil.Name = "Profil";
            this.Profil.Size = new System.Drawing.Size(98, 25);
            this.Profil.TabIndex = 3;
            this.Profil.Text = "Профил";
            this.Profil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Profil_MouseDown);
            this.Profil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Profil_MouseMove);
            // 
            // minbtn
            // 
            this.minbtn.BackColor = System.Drawing.Color.SlateBlue;
            this.minbtn.FlatAppearance.BorderSize = 0;
            this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbtn.Image = global::project.Properties.Resources.remove;
            this.minbtn.Location = new System.Drawing.Point(770, 7);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(41, 34);
            this.minbtn.TabIndex = 2;
            this.minbtn.UseVisualStyleBackColor = false;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.SlateBlue;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Image = global::project.Properties.Resources.cross;
            this.closebtn.Location = new System.Drawing.Point(817, 6);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(48, 37);
            this.closebtn.TabIndex = 1;
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Image = global::project.Properties.Resources.back_button;
            this.backbtn.Location = new System.Drawing.Point(3, 3);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(38, 37);
            this.backbtn.TabIndex = 0;
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Име";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Парола ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(2, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ймеил";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(2, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Адрес";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(86, 98);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(1, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(86, 98);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateBlue;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(1, 272);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(87, 98);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateBlue;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(1, 384);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(86, 98);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SlateBlue;
            this.panel6.Location = new System.Drawing.Point(1, 143);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(733, 22);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SlateBlue;
            this.panel7.Location = new System.Drawing.Point(1, 253);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(733, 22);
            this.panel7.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SlateBlue;
            this.panel8.Location = new System.Drawing.Point(1, 367);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(733, 19);
            this.panel8.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.SlateBlue;
            this.panel9.Location = new System.Drawing.Point(1, 481);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(733, 17);
            this.panel9.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SlateBlue;
            this.panel10.Controls.Add(this.button1);
            this.panel10.Location = new System.Drawing.Point(733, 47);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(136, 451);
            this.panel10.TabIndex = 18;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::project.Properties.Resources.refresh;
            this.button1.Location = new System.Drawing.Point(17, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 79);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(83, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(651, 98);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(651, 98);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 272);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(651, 98);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 384);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(651, 98);
            this.textBox4.TabIndex = 21;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(871, 500);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Profil;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}