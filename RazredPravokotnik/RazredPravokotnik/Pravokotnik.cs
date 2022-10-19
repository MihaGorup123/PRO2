using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazredPravokotnik
{

    internal class Pravokotnik
    {
        public override string ToString()
        {
            return "Višina: "+Višina+"\n Širina: "+Širina;
        }

        protected double Širina;
        protected double Višina;
        private double Ploščina;

        public double Širina1 { get => Širina; set => Širina = value; }
        public double Višina1 { get => Višina; set => Višina = value; }
        public double Ploščina1 { get => Ploščina; }

        static public bool operator==(Pravokotnik p,Pravokotnik p1)
            {
            return p1.Ploščina == p.Ploščina;
            }
        static public bool operator !=(Pravokotnik p, Pravokotnik p1)
        {
            return p1.Ploščina != p.Ploščina;
        }

        static public bool operator <(Pravokotnik a,Pravokotnik b)
        {
            return a.Ploščina < b.Ploščina;
        }

        static public bool operator >(Pravokotnik a, Pravokotnik b)
        {
            return a.Ploščina > b.Ploščina;
        }

        static public bool operator <=(Pravokotnik a, Pravokotnik b)
        {
            return a.Ploščina <= b.Ploščina;
        }
        static public bool operator >=(Pravokotnik a, Pravokotnik b)
        {
            return a.Ploščina >= b.Ploščina;
        }
        

        public Pravokotnik()
        {
            Višina = 0;
            Širina = 0;
        }

        public Pravokotnik(double a,double b)
        {
            Višina = b;
            Širina = a;
            Ploščina = a * b;
        }
    }
}
