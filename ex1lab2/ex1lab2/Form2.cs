using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {

        }
        
        private readonly string username;


        public Form2(string username)
        {
            InitializeComponent();
            this.username = username;
            label1.Text = "Hello " + username;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
       

    }


