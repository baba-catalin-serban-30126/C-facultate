using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema1ii
{
    public partial class Form1 : Form
    {
        private readonly string[] listainitiala = { "Unt","Lapte","Oua","Paine","Rosii","Castraveti","Cartofi" };
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void initializere()
        {
            listBox1.Items.AddRange(listainitiala);
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if(textBox1.Text != null)
           listBox1.Items.Add(textBox1.Text);
            textBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializere();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(listainitiala);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sortedList = listBox1.Items.Cast<string>().OrderBy(item => item).ToArray();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(sortedList);
        }
    }
}
