using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal class Fizikalec:Mutant
    {
        protected int moč;
        protected int iQ;


        public int Moč { get => moč; set => moč = value; }
        public int IQ { get => iQ; set => iQ = value; }

        public override int KvocientNevarnosti()
        {
            return Stopnja*IQ*Moč;
        }
    }
}
