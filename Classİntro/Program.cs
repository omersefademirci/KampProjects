using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //class'ın değişkenini tanımlama
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Sefa Demirci";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Berkay Çelik";
            kurs3.IzlenmeOrani = 80;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        
        public string KursAdi { get; set; }
        
        public string Egitmen { get; set; }

        public int IzlenmeOrani{ get; set; }


    }



}
