using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGIt
{
    internal class Kupec
    {
        protected string ime;
        protected decimal stanje;

        public decimal Stanje { get => stanje;}
        public string Ime { get => ime; set => ime = value; }

        public void BeležiPlačilo(decimal plačilo)
        {
            stanje -= plačilo;
        }

        public void beležiKlic(int min,TipKlica tip)
        {
            switch(tip)
            {
                case TipKlica.Stacionarno:
                    stanje+=min*0.12m;
                    break;

                case TipKlica.Mobilno:
                    stanje += min * 0.03m;
                    break;
                default:
                    break;

                
            }
        }
    }
}
