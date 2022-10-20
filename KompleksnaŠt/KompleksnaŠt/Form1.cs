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
 /**********************************************************************************************************/
      
/***********************************************************************************************************/
        private void label8_Click(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double re1 = double.Parse(textBox1.Text);
            double im1 = double.Parse(textBox2.Text);
            KompŠt a = new KompŠt(re1,im1) ;
            double re2 = double.Parse(textBox3.Text);
            double im2 = double.Parse(textBox4.Text);
            KompŠt b = new KompŠt(re2, im2);

            Rezultat.Text = (a + b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double re1 = double.Parse(textBox1.Text);
            double im1 = double.Parse(textBox2.Text);
            KompŠt a = new KompŠt(re1, im1);
            double re2 = double.Parse(textBox3.Text);
            double im2 = double.Parse(textBox4.Text);
            KompŠt b = new KompŠt(re2, im2);

            Rezultat.Text = (a - b).ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double re1 = double.Parse(textBox1.Text);
            double im1 = double.Parse(textBox2.Text);
            KompŠt a = new KompŠt(re1, im1);
            double re2 = double.Parse(textBox3.Text);
            double im2 = double.Parse(textBox4.Text);
            KompŠt b = new KompŠt(re2, im2);

            Rezultat.Text = (a * b).ToString();
        }
    }
}
