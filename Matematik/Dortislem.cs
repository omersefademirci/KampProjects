using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class Dortislem
    {
        public void Topla(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Sonuc: {0} ", c);
        }
        public void Cıkarma(int a,int b)
        {
            int c = a - b;
            Console.WriteLine("Sonuc: {0} ", c);
        }
        public void Bolme(int a, int b)
        {
            double c =Convert.ToDouble( a) / b;
            Console.WriteLine("Sonuc: {0} ", c);
        }

    }
}
