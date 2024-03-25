using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void plusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numar1 = Convert.ToInt32(textBox1.Text);
            int numar2 = Convert.ToInt32(textBox2.Text);

            
            int rezultat = numar1 + numar2;

            
            textBox3.Text = rezultat.ToString();
        }

        private void minusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numar1 = Convert.ToInt32(textBox1.Text);
            int numar2 = Convert.ToInt32(textBox2.Text);


            int rezultat = numar1 - numar2;


            textBox3.Text = rezultat.ToString();
        }

        private void inmultireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numar1 = Convert.ToInt32(textBox1.Text);
            int numar2 = Convert.ToInt32(textBox2.Text);


            int rezultat = numar1 * numar2;


            textBox3.Text = rezultat.ToString();
        }

        private void impartireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numar1 = Convert.ToInt32(textBox1.Text);
            int numar2 = Convert.ToInt32(textBox2.Text);


            int rezultat = numar1 / numar2;


            textBox3.Text = rezultat.ToString();
        }
    }
}
