using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create

            //Dictionary sınıfı eklendiği elemanları key ve value olarak kaydetmemize yarayan bir sınıfdır.
            // Kullanabilmek için  sayfa başında; using System.Collections.Generic; tanımlamalısınız.
            Dictionary<int,string> users = new Dictionary<int, string>();
            // Add metodu  ile ekleme yapılabilir.
            users.Add(0, "Sefa Demirci");
            users.Add(1, "Metehan Gokay");
            users.Add(2, "Emir Odabaşı");
            users.Add(3, "Mustafa Celik");

            // Dictionaryde ki Key islemi Keyvaluepair'dır.
            // console yazdıralım

            foreach (KeyValuePair<int, string> user in users)
            {
                Console.WriteLine("Id: " + user.Key + "\t" + "Ad Soyad: " + user.Value);
            }
            //***********************************************************
            Console.WriteLine("***********************************************************\n");
            Console.WriteLine("Ögelere nasıl erişilir ?");
            // Ögelere nasıl erişilir ?

            var cities = new Dictionary<string, string>(){
                {"Izmir", "Bornava, Balcova, Bergama"},
                {"Kastamonu", "Pinarbasi, Azdavay, Taskopru"},
                {"İstanbul", "Bagcilar, Kadikoy, Beylikduzu"}
            };

            Console.WriteLine(cities["Izmir"]); //Izmirin anahtar kelimesini yazar
            Console.WriteLine(cities["Kastamonu"]);//Kastamonunun anahtar kelimesini yazar
            //Console.WriteLine(cities["Adana"]); // Çalışma zamanında hata verir çünkü Anahtar kelime Adana bulunamaz.

            // Anahtar değerleri kontrol etmek için: ContainsKey() kullanılır.
            // bir if else ile  görelim.
            if (cities.ContainsKey("Adana")) // Anahtar kelime Adanının olup olmadığı kontrol eder
            {
                Console.WriteLine(cities["Adana"]); // Adana ile başlayan anahtar kelime var ise bunu yazdırır
            }
            //Bilinmeyen bir anahtarın degerini almak için : TryGetValue() kullanın.
            // kullanımını aşağıdaki if blogunda görelim.
            string result;
            if (cities.TryGetValue("Adana",out result))
            {
                Console.WriteLine(result);
                //string değerinde Adana değişkeni var mı varsa yazdır.
            }
            //For dongusu kullanan Dictionary generetic ögeleri:
            // index değerini kullanarak, key-value ile değerleri alabilmek için ElementAt() kullanılır.
            // ElementAt() kullanabilmek için yukarıda  using System.Linq; tanımlamalısınız.
            for (int i = 0; i <cities.Count; i++)
            {
                Console.WriteLine("Şehir: {0}\t Ilceler: {1}" ,cities.ElementAt(i).Key,cities.ElementAt(i).Value);
            }


            //***********************************************************
            Console.WriteLine("***********************************************************\n");
            Console.WriteLine("Dictionary Generetic Update\n\n");
            //Dictionary Generetic Update
            var cities2 = new Dictionary<string, string>(){
                {"Izmir", "Bornava, Balcova, Bergama"},
                {"Kastamonu", "Pinarbasi, Azdavay, Taskopru"},
                {"İstanbul", "Bagcilar, Kadikoy, Beylikduzu"}
            };
            cities2["Izmir"]= "Karşıyaka,Kemalpaşa,Karaburun";
            /*
             *  citis2 olan dictionary generetic yapısının: key olan Izmir'ın,value-lerini update ediyoruz.
             *  Eger bir key in  value değerini update ederken olup olmadıgını kontrol etmek istersek aşağıda ki gibi kullanabiliriz.
             */
            if (cities2.ContainsKey("Kastamonu"))
            {
                cities2["Kastamonu"] = "Araç,Ağlı,Bozkurt,Cide,Daday";
                //Eğer Key anahtar sözcügü var ise value değerlerini değiştiriyor
            }
            //foreach döngüsü ile yaptıgımız update ettiğimiz değerlerle birlikte console yazdıralım.
            foreach (var cit in cities)
            {
                Console.WriteLine("Şehir: {0}\tIlçeler:{1}",cit.Key,cit.Value);
            }
            //***********************************************************
            Console.WriteLine("***********************************************************");


            // Remove  Elements in  Generetic Dictionary 
            Console.WriteLine("Generetic Dictionary elementlerini  silme.\n\n");

            var cities3 = new Dictionary<string, string>(){
                {"Izmir", "Bornava, Balcova, Bergama"},
                {"Kastamonu", "Pinarbasi, Azdavay, Taskopru"},
                {"İstanbul", "Bagcilar, Kadikoy, Beylikduzu"}
            };
            cities3.Remove("Izmir");//silmek istediginiz key
            // silmek istediginiz key var mı yok mu , var ise silinsin işlemi nasıl yapılır ?
            if (cities3.ContainsKey("Kastamonu"))
            {
                cities3.Remove("Kastamonu");
            }
            // tüm bağılları silme
            // cities3.Clear()

            Console.ReadKey();
        }
    }
}
