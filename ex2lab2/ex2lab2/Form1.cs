using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace ex2lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void load()
        {
            StreamReader streamReader = new StreamReader(path: "fisier1.txt");
            listBox1 = new ListBox();
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection items = listBox2.Items;
            items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(object item in listBox1.Items)
   
                
                listBox2.Items.Add(item);
            }
        }
    }

