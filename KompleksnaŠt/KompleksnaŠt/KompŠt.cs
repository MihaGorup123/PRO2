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
    }
}
