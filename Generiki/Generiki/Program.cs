using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sklad a = new sklad();
            a.Push(1);a.Push("!");

            GenSklad<string> b = new GenSklad<string>();
            b.Push("1");b.Push("dva");

            GenSklad<double> c = new GenSklad<double>();
            c.Push(1);c.Push(Math.PI);


            Console.ReadLine();
        }
    }
}
