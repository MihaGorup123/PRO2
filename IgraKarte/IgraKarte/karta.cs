using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraKarte
{
    internal class karta
    {
        public barve barva { get; set; }
        public vrednosti vrednost { get; set; }
        public string ime { get; set; }


        public karta(barve b,vrednosti v)
        {
            barva = b;
            vrednost = v;
            ime = v + " " + b;
        }
    }
}
