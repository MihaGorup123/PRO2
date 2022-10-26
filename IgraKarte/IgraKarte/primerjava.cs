using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgraKarte
{
    internal class primerjava : IComparer<karta>
    {
        public int Compare(karta x, karta y)
        {
            if (x.barva < y.barva)
                return -1;
            if (x.barva > y.barva)
                return 1;
            if (x.vrednost < y.vrednost)
                return -1;
            if (x.vrednost > y.vrednost)
                return 1;
            return 0;
        }
    }
}
