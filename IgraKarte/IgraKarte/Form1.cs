using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgraKarte
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        kup k1 = new kup();
        kup k2;
        public Form1()
        {
            InitializeComponent();
            List<karta> nak = new List<karta>();
            for(int i=0;i<10;i++)
            {
                int x = r.Next(nak.Count);
                nak.Add(nak[x]);
            }
            k2 = new kup(nak);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnPonastavi1_Click(object sender, EventArgs e)
        {

        }

        private void btnMešaj1_Click(object sender, EventArgs e)
        {

        }

        private void btnPonastavi2_Click(object sender, EventArgs e)
        {

        }
    }
}
