using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    internal class Program
    {
        public override string ToString()
        {
            return base.ToString();
        }
        struct Vektor
        {
            public double x, y, z;

            public Vektor(double x1, double y1, double z1)
            {
                x = x1; y = y1; z = z1;
            }

            public Vektor(Vektor v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
            public static Vektor operator+(Vektor levi,Vektor desni)
            {
                Vektor r = new Vektor();
                r.x = levi.x + desni.x;
                r.y = levi.y + desni.y;
                r.z = levi.z + desni.z;
                return r;
            }
            public static Vektor operator*(double a,Vektor b)
            {
                Vektor r = new Vektor();
                r.x = a * b.x;
                r.y = a * b.y;
                r.z = a * b.z;
                return r;
            }
            public static Vektor operator *(Vektor a, double b)
            {
                return b*a;
            }
            public static double operator*(Vektor a,Vektor b)
            {
                return a.x * b.x * a.y * b.y * a.z * b.z;
            }
        }

        static void Main(string[] args)
        {
            Vektor V;
            V.x = 1;
            V.y = -1;
            V.z = 0;

            Vektor a;
            a.x = 2;
            a.y = 3;
            a.z = -2;
            Vektor c = V + a;
            Console.WriteLine(c.ToString());
            c = 5 * V;
            Console.WriteLine(c.ToString());
            Console.ReadLine();
        }
    }
}
