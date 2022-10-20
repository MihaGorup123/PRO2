using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KompleksnaŠt
{
    internal class KompŠt
    {
        double re;
        double im;

        public double Re { get => re; set => re = value; }
        public double Im { get => im; set => im = value; }

        public KompŠt(double r,double i)
        {
            re = r;im = i;
        }
        //kodaza + - *
        public static KompŠt operator +(KompŠt a, KompŠt b)
        {
            KompŠt r = new KompŠt(0, 0);
            r.Re = a.Re + b.Re;
            r.Im = a.Im + b.Im;
            return r;
        }

        public static KompŠt operator -(KompŠt a, KompŠt b)
        {
            KompŠt r = new KompŠt(0, 0);
            r.Re = a.Re - b.Re;
            r.Im = a.Im - b.Im;
            return r;
        }

        public static KompŠt operator *(KompŠt a, KompŠt b)
        {//bd=re, ac=im
            // množenje (a+bi)*(c+di)= ac-bd+(ad+bc)i 
            KompŠt r = new KompŠt(0, 0);
            r.Re = a.Im * b.Im - a.Re * b.Re;
            r.Im = a.Im + b.Re + a.Re*b.Im;
            return r;
        }

        public override string ToString()
        {
            return Re+" i * "+Im;
        }

    }
}
