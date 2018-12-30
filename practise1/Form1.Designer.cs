namespace practise1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.green = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blue = new System.Windows.Forms.Panel();
            this.red = new System.Windows.Forms.Panel();
            this.white = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.purple = new System.Windows.Forms.Panel();
            this.blue.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a color";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.Location = new System.Drawing.Point(246, 235);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(103, 88);
            this.green.TabIndex = 1;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(246, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 88);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Controls.Add(this.panel5);
            this.blue.Location = new System.Drawing.Point(352, 141);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(103, 88);
            this.blue.TabIndex = 2;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(458, 141);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(103, 88);
            this.red.TabIndex = 2;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(352, 235);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(103, 88);
            this.white.TabIndex = 2;
            this.white.Click += new System.EventHandler(this.white_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Location = new System.Drawing.Point(109, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(103, 88);
            this.panel5.TabIndex = 3;
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.Location = new System.Drawing.Point(458, 235);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(103, 88);
            this.purple.TabIndex = 3;
            this.purple.Click += new System.EventHandler(this.purple_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purple);
            this.Controls.Add(this.white);
            this.Controls.Add(this.red);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.green);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.blue.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel green;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel blue;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel red;
        private System.Windows.Forms.Panel white;
        private System.Windows.Forms.Panel purple;
    }
}

