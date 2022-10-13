using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGIt
{
    internal class kupec60:Kupec
    {
        private int VišjaTarifaPorabljeno;
        public override void beležiKlic(int min,TipKlica tip)
        {
            switch (tip)
            {
                case TipKlica.Stacionarno:
                    stanje += min * 0.12m;
                    break;

                case TipKlica.Mobilno:
                    int vMinute, nMinute;
                    int šeVMinute = (VišjaTarifaPorabljeno < 60) ?
                        60 - VišjaTarifaPorabljeno : 0;
                    if(min>šeVMinute)
                    {
                        vMinute = šeVMinute;
                        nMinute = min - vMinute;
                    }
                    else
                    {
                        vMinute = min;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.035m + nMinute * 0.01m;
                    VišjaTarifaPorabljeno += vMinute;
                    break;
                default:
                    break;


            }
        }
    }
}
