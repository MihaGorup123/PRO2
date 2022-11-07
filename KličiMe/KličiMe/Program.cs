using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KličiMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imeDatoteke = @"D\PRO2\b.txt";
            Balec osebe = new Balec();
            try
            {
                osebe.Odpri(imeDatoteke);
                for(int k=0;k<osebe.NOseb;k++)
                {
                    osebe.ObravnavajNaslednjega();
                }
            }
            catch (FileNotFoundException x)
            {
                Console.WriteLine("datoteka "+imeDatoteke+" ne obstaja");
            }
            catch (KličiMeExeption x)
            {
                Console.WriteLine("Datoteka ima napačno strukturo");
            }
            catch(Exception y)
            { 
                Console.WriteLine("program => samomor " +y.Message);
            }
            Console.ReadLine();
        }
    }
}
