using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class povezanalista<k,t> where k:IComparable
    {
        vozel<k, t> glava;
        public povezanalista()
        {
            glava = new vozel<k, t>();
        }
        public void dodaj(k key,t item)
        {
            vozel<k, t> nov = new vozel<k, t>(key, item, glava.naslednji);
            glava.naslednji = nov;
        }
        public t najdi(k key)
        {
            vozel<k, t> trenutni = glava;
            while(trenutni.naslednji!=null)
            {
                if (trenutni.ključ.CompareTo(key)==0)
                    break;
                else
                    trenutni = trenutni.naslednji;
            }
            return trenutni.vsebina;
        }
    }
}
