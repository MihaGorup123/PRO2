using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class vozel<k,t>
    {
        public k ključ;
        public t vsebina;
        public vozel<k, t> naslednji;

        public vozel()
        {
            ključ = default(k);
            vsebina = default(t);
            naslednji = null;
        }
        public vozel(k k,t t,vozel<k,t> n)
        {
            ključ = k;vsebina = t;naslednji = n;

        }
    }
}
