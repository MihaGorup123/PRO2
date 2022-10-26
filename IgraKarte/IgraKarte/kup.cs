using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IgraKarte
{
    internal class kup
    {
        List<karta> kupec;
        Random r = new Random();

        public kup()
        {
            kupec = new List<karta>();
            for(int b=0;b<4;b++)
            {
                for(int v =1; v<=13;v++)
                {
                    kupec.Add(new karta((barve)b, (vrednosti)v));
                }
            }

            
           
        }
        public kup (IEnumerable<karta> začetek)
            {
                kupec = new List<karta>(začetek);
            }

        public void Add(karta nova)
        {
            kupec.Add(nova);
        }

        public int Count
        {
            get { return kupec.Count; }
        }

        public void Sort()
        {
            kupec.Sort(new primerjava());
        }

        public List<string> Imenakart()
        {
            List<string> imena = new List<string>();
            foreach (karta k in kupec)
                imena.Add(k.ime);
            return imena;
        }

        public karta Deli (int indeks)
        {
            karta x = kupec[indeks];
            kupec.RemoveAt(indeks);
            return x;
        }
        public void mešaj()
        {
            List<karta> zmešano = new List<karta>();
            while(kupec.Count>0)
            {
                int x = r.Next(kupec.Count);
                zmešano.Add(kupec[x]);
                kupec.RemoveAt(x);
            }
            kupec = zmešano;
        }
    }
}
