using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // class değeişkeni tanımlama

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya Elması";
            urun1.Fiyati =15;
            urun1.Id =1;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyati = 50;
            urun2.Id = 2;

            Urun[] urunler = new Urun[] {urun1,urun2};
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + ' ' + urun.Aciklama + ' ' + urun.Fiyati);
            }
            Console.WriteLine("****************__Metotlar__**********************");
            // tekrar tekrar aynı şeyi kullanabilir
            //encapsulation--
            SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);

        }
    }
}
