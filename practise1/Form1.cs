using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            label1.BackColor = panel1.BackColor;
        }

        private void blue_Click(object sender, EventArgs e)
        {
            label1.BackColor = blue.BackColor;
        }

        private void red_Click(object sender, EventArgs e)
        {
            label1.BackColor = red.BackColor;
        }

        private void green_Click(object sender, EventArgs e)
        {
            label1.BackColor = green.BackColor;
        }

        private void white_Click(object sender, EventArgs e)
        {
            label1.BackColor = white.BackColor;
        }

        private void purple_Click(object sender, EventArgs e)
        {
            label1.BackColor = purple.BackColor;
        }
    }
}
