using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practise2
{    
    public partial class Form1 : Form
    {
        const int size = 10;
        int i = 0;
        int[] numbers = new int[size];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            
            Random numrandom = new Random();
            for (int i = 0; i < size; i++)
            {
                numbers[i] = numrandom.Next(0, 100);                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = Convert.ToString(numbers[i]);
            if (i == size - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            
        }
    }
}
