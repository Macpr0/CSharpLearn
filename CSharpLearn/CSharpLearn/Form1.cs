using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Oben_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = -100;
        }

        private void Unten_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = 100;
        }

        private void Links_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = -100;
        }

        private void Rechts_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Left = 100;
        }

        private void Mitte_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(190, 33);
        }
    }
}
