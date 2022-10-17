using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGIt
{
    internal class ZlatiKupec:Kupec
    {
        public override void beležiKlic(int min, TipKlica tip)
        {
            base.beležiKlic(min, tip);
            stanje = stanje * 10;
        }
    }
}
