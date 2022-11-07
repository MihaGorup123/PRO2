using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KličiMe
{
    internal class KličiMeExeption:ApplicationException
    {
        public KličiMeExeption(string sporočilo):base(sporočilo)
        {
        }
        public KličiMeExeption(string sporočilo, Exception notranja):
            base(sporočilo,notranja)
        {
        }
    }
}
