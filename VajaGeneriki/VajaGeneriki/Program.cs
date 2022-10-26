using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaGeneriki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            povezanalista<int, string> x = new povezanalista<int, string>();
            x.dodaj(1, "a2");
            x.dodaj(5, "ccccc");
            x.dodaj(2, "sdbk");
            string r = x.najdi(5);
            Console.WriteLine(r);
            Console.ReadLine();

            povezanalista<DateTime, string> y = new povezanalista<DateTime, string>();
            y.dodaj(DateTime.Now, "umri");
        }
    }
}
