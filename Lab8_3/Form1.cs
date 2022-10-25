using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = Convert.ToString(hScrollBar1.Value);
            int n = hScrollBar1.Value;
            int n1 = (n + 1) * (n + 1);
            int n2 = n * n;
            double rez = (n2 * n1) / 4;
            textBox2.Text = rez.ToString();
            int i1 = 0;
            for (int i = 1; i <= n; i++)
            {
                i1 = (i * i * i) + i1;
            }
            textBox3.Text = i1.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
