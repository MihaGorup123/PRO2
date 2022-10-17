using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    internal class Psiho:Mutant
    {
        protected int iQ;
        protected int številoUporabe;


 
        public int ŠteviloUporabe { get => številoUporabe; set => številoUporabe = value; }
        public int IQ { get => iQ; set => iQ = value; }

        public override int KvocientNevarnosti()
        {
            return Stopnja * IQ * številoUporabe;
        }
    }
}
