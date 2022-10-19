using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KompleksnaŠt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           string t1 = textBox1.Text;
           int št1 = int.Parse(t1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string t2 = textBox2.Text;
            int št2 = int.Parse(t2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string t3 = textBox3.Text;
            int št3 = int.Parse(t3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string t4 = textBox4.Text;
            int št4 = int.Parse(t4);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double re1 = double.Parse(textBox1.Text);
            double im1 = double.Parse(textBox2.Text);
            KompŠt a = new KompŠt(re1,im1) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
