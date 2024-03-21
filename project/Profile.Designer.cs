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
            this.Minimize = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 43);
            this.panel1.TabIndex = 7;
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(168, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(54, 37);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "__";
            this.Minimize.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(3, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(39, 35);
            this.back.TabIndex = 0;
            this.back.Text = "<--";
            this.back.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(228, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(54, 37);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(71, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 264);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(71, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(635, 264);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(71, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(635, 264);
            this.panel4.TabIndex = 9;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 407);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}