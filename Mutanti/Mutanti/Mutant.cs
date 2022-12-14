using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutanti
{
    abstract class Mutant : IPrikazovalnik
    {
        protected string ime;
        protected int stopnja;

        public string Ime { get => ime; set => ime = value; }
        public int Stopnja { get => stopnja; set => stopnja = value; }

        public void PrikažiInformacije()
        {
            Console.WriteLine("Mutant "+ime+" ima kvocient nevarnosti "+KvocientNevarnosti());
        }
        public abstract int KvocientNevarnosti();
    }
}
