using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Audi");
            listBox1.Items.Add("Cluj-Napoca");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select=listBox1.SelectedIndex.ToString();
            PictureBox pictureBox1 = new PictureBox();
            switch (select)
            {
                case "Audi":
                    pictureBox1.Image = Properties.Resources.audipicture; 
                    break;
                case "Cluj-Napoca":
                    pictureBox1.Image = Properties.Resources.oraspicture;
                    break;
                   
            }
        }
    }
}
