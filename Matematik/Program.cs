using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Yapmak istediginiz islem (+, /, *, -)");
            string islem = Console.ReadLine();
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            Dortislem dortIslem = new Dortislem();
            if (islem == "+") 
            {
                dortIslem.Topla(a, b); 
            }
            else if (islem == "-")
            {
                dortIslem.Cıkarma(a, b);
            }else if (islem == "*")
            {
                dortIslem.Cıkarma(a, b);
            }else if(islem == "/")
            {
                dortIslem.Bolme(a, b);
            }
           
            
        }
    }
}
