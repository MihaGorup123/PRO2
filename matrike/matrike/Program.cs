using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matrika m1 = new Matrika();
            //Matrika m2 = new Matrika();
            //Random r = new Random();
            //for (int x = 0; x < 3; x++)
            //    for (int y = 0; y < 3; y++)
            //    {
            //        m1.m[x, y] = r.NextDouble();
            //        m2.m[x, y] = r.NextDouble();
            //    }
            //Console.WriteLine("Matrika 1");
            //m1.Tiskaj();
            //Console.WriteLine("Matrika 2");
            //m2.Tiskaj();
            //Console.WriteLine("Matrika 3");
            //Matrika m3 = m1 + m2;
            //m3.Tiskaj();
            //Console.ReadLine();

            Matrika a = new Matrika();
            a[0, 0] = 1;
            a[0, 1] = 1;
            a[0, 2] = 0;
            a[1, 0] = 1;
            a[1, 1] = 2;
            a[1, 2] = 1;
            a[2, 0] = 0;
            a[2, 1] = 1;
            a[2, 2] = 0;
            Matrika b = new Matrika();
            b[0, 0] = 1;
            b[0, 1] = 1;
            b[0, 2] = 1;
            b[1, 0] = 2;
            b[1, 1] = 2;
            b[1, 2] = 2;
            b[2, 0] = 0;
            b[2, 1] = 1;
            b[2, 2] = 0;
            a.Tiskaj();
            Console.WriteLine();
            b.Tiskaj();
            Console.WriteLine();
            Matrika c = new Matrika();
            c = a + b;
            Console.WriteLine("Rezultat");
            c.Tiskaj();
            Console.ReadLine();
        }
    }
}
