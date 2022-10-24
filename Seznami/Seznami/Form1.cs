using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Seznami
{
    public partial class Form1 : Form
    {
        ArrayList seznam = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            seznam.Add(LastnostVnos.Text);
            textBox1.Text = "Vnešen element v seznam " + LastnostVnos.Text;
            LastnostVnos.Clear();
        }

        private void btnIzpis_Click(object sender, EventArgs e)
        {
            string rezultat = "Elementi so "+Environment.NewLine;
            for(int k=0;k<seznam.Count;k++)
            {
                rezultat += seznam[k] + Environment.NewLine;
            }
            textBox1.Text = rezultat;
        }

        private void btnOdstrani_Click(object sender, EventArgs e)
        {
            seznam.Remove(LastnostVnos.Text);
            textBox1.Text = "Odstranjn elemet" + LastnostVnos.Text;
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            if (seznam.Count > 0)
                textBox1.Text = "prvi element je " + seznam[0].ToString();

            else
                textBox1.Text = "Seznam je prazen";
        }

        private void btnZadnji_Click(object sender, EventArgs e)
        {
            if (seznam.Count > 0)
                textBox1.Text = "prvi element je " + seznam[seznam.Count-1].ToString();

            else
                textBox1.Text = "Seznam je prazen";
        }

        private void btnPrazna_Click(object sender, EventArgs e)
        {
            if (seznam.Count > 0)
                textBox1.Text = "Seznam ni prazen";

            else
                textBox1.Text = "Seznam je prazen";
        }

        private void btnVsebuje_Click(object sender, EventArgs e)
        {
            if(seznam.Contains(LastnostVnos.Text))
            {
                textBox1.Text="Seznam vsebuje element " + LastnostVnos.Text;
            }
            else
                textBox1.Text="Seznam ne vsebuje elementa"+ LastnostVnos.Text;
        }

        private void btnLokacija_Click(object sender, EventArgs e)
        {
            if (seznam.Contains(LastnostVnos.Text))
            {
                textBox1.Text = seznam.IndexOf(LastnostVnos.Text)+1.ToString();
            }
            else
                textBox1.Text = "Seznam ne vsebuje elementa" + LastnostVnos.Text;
            
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
           seznam.TrimToSize();
           textBox1.Text = "Seznam Skrajšan";
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Velikost seznama " + seznam.Count + " in kapaciteta seznama je " + seznam.Capacity;
        }
    }
}
