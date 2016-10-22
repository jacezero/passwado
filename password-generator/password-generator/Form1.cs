using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              
        private string generatepassword(int length)
        {
            Random r = new Random();
            StringBuilder sp = new StringBuilder(length);
            for(int i = 0; i < length; i++)
            {
                int val = r.Next(33, 125);
                char sym = (char)val; sp.Append(sym); 
            }
            return sp.ToString();

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            int length = (int) this.numericUpDown1.Value;
            string pwd = generatepassword(length);
                        this.textBox1.Text=pwd;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
