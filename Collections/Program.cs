using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                string[] names = new string[] { "Engin", "Tarık", "Dogukan" };
                Console.WriteLine(names[0]);
                Console.WriteLine(names[1]);
                Console.WriteLine(names[2]);

                //  wrong use <--> yanlış kullanım
                names = new string[5];
                //
                names[4] = "Batuhan";
                Console.WriteLine(names[4]);
                Console.WriteLine(names[0]);
            */
            //******************************************************
            //Collections

            //  This is required to add the list.This part should be written above.
            //using System.Collections.Generic;

            List<string> names2 = new List<string> { "Engin", "Tarık", "Dogukan" };
            //names2.Add("Hakan");

            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            names2.Add("Batuhan");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

        }
    }
}
