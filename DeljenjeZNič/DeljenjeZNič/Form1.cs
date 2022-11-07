using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeljenjeZNič
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeli_Click(object sender, EventArgs e)
        {    
            try
            {
                int Delj = int.Parse(txtDeljenec.Text);
                int Deli = int.Parse(txtDeljitelj.Text);
                int rez;

                rez = Delj / Deli;
                Rezultat.Text = rez.ToString();
                Rezultat.Visible = true;
                if (Deli == 0)
                    throw new IndexOutOfRangeException
                        ("Deljenje z 0");
            }

            catch (Exception exs)
            {
                MessageBox.Show("vnešeni morata biti dve celi števili \n"+exs.Message);
            }
        }
    }
}
