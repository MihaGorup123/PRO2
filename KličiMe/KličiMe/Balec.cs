using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KličiMe
{
    internal class Balec
    {
        FileStream fs;
        StreamReader sr;
        uint število;
        public void Odpri(string ImeDatoteke)
        {
            fs = new FileStream(ImeDatoteke, FileMode.Open);
            sr = new StreamReader(fs);
            try
            {
                string PrvaVrstica = sr.ReadLine();
                število = uint.Parse(PrvaVrstica);
            }
            catch(FormatException)
            {
                Console.WriteLine("Prvo št. v datoteki ni pozitivno celo oz. ne obstaja");
            }
        }
        public uint NOseb
        {
            get { return število; }
        }

        public void ObravnavajNaslednjega()
        {
            try
            {
                string ime = sr.ReadLine();
                if(ime==null)
                {
                    throw new KličiMeExeption("Ni dovolj imen");
                }
                if (ime[0]=='Z')
                {
                    throw new TajniAgentException(ime);
                }
                Console.WriteLine("Pokliči "+ime);
            }
            catch (TajniAgentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
