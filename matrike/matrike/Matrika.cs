using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace matrike
{
    internal class Matrika
    {
        public double[,] m = new double[3, 3];

        public double this[int x, int y]
        {
            get { return m[x, y]; }
            set { m[x, y] = value; }
        }
        public void Tiskaj()
        {
            for (int k=0;k<3;k++)
            {
                for (int j=0;j<3;j++)
                {
                    Console.Write(m[k,j]+"\t");
                }
                Console.WriteLine();
            }
        }
        public static Matrika operator *(Matrika a,Matrika b)
        {
            Matrika r = new Matrika();
            for(int k=0;k<3;k++)
            {
                for (int j=0; j<3;j++)
                {
                    r[k, j] = a[k, 0] * b[0, j] + a[k, 1] * b[1, j] + a[k, 2] * b[2, j];
                }
            }
            return r;
        }

        public static Matrika operator +(Matrika a, Matrika b)
        {
            Matrika r = new Matrika();
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j< 3; j++)
                {
                    r[k, j] = a[k, j] + b[k, j];
                }
            }
            return r;
        }


    }
}
