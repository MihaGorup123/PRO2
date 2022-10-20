using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            izpišisporočilo();              //kliče metodo s istim št. parametrov
            izpišisporočilo("java","zelo");
            izpišisporočilo("pyton","zelo");
            string a = "VB";
            izpišisporočilo(a);
            Console.WriteLine("Kateri je tvoj najljubši jezik?");
            string moj = Console.ReadLine();
            izpišisporočilo(moj, "zelo");
            
        }
        //nova metoda- metoda overloading
        public static void izpišisporočilo(string jezik,string koliko)

        {
            Console.WriteLine("rad imam "+jezik+""+koliko);
            return;
        }
       public static void izpišisporočilo()
        {
            Console.WriteLine("brez parametrov");
            Console.WriteLine("Rad imam c#");

        }
        public static void izpišisporočilo(string jezik)
        {
            Console.WriteLine("en parameter");
            Console.WriteLine("rad imam"+jezik);

        }
    }
}
