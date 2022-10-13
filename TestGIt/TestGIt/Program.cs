using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kupec Janez = new Kupec();
            Janez.Ime = "janez Novak";
            Janez.beležiKlic(10, TipKlica.Stacionarno);
            Console.WriteLine(Janez.Ime+" dolguje "+Janez.Stanje);

            kupec60 Alenka = new kupec60();
            Alenka.Ime = "Alenka Novak";
            Alenka.beležiKlic(100, TipKlica.Mobilno);
            Console.WriteLine(Alenka.Ime + " dolguje " + Alenka.Stanje);

            Console.ReadLine();
        }
    }
}
