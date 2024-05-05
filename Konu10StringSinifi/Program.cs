namespace Konu10StringSinifi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Sınıfı!");
            string degisken;
            char karakter = 'z';
            string metin = "String yan yana dizilmiş char yapısıdır";
            // Ornek();
            StringMetotlari();
        }
        static void Ornek()
        {
            string birMetin = "Ankara Başkenttir";
            String birSayi = "123456789";
            System.String birTarih = "05.05.2024"; // string system kütüphanesinde bulunur
            Console.WriteLine("birMetin veri tipi: " + birMetin.GetType());
            Console.WriteLine("birSayi veri tipi: " + birSayi.GetType());
            Console.WriteLine("birTarih veri tipi: " + birTarih.GetType());
            string s = "Barış Manço"; // s karakterlerden oluşan bir dizidir
            Console.WriteLine("s: " + s);
            for (int i = 0; i < s.Length; i++) // s değişkenindeki karakter kadar dön
            {
                Console.WriteLine($"s[{i}] : {s[i]}"); // döngü her döndüğünde ilgili indexteki karakteri ekran yazdır. s[i] kodu s değişkenindeki i. karakteri ekrana yazar.
            }
            foreach (var item in s) // foreach ile s değişkenindeki her bir karakteri ekran yazdırabiliriz.
            {
                Console.WriteLine(item); // item s değişkenindeki her bir karaktere karşılık gelir.
            }
        }
        static void StringMetotlari()
        {
            string metin = "Stringin birçok metodu vardır";
            Console.WriteLine("metin: " + metin);
            Console.WriteLine("metnin karakter sayısı: " + metin.Length); // Length bize değişkenin kaç karakterden oluştuğu bilgisini verir.
            var klon = metin.Clone();
            Console.WriteLine("metnin klonu: " + klon);

            metin = "My name is Alp";

            Console.WriteLine("metin: " + metin);

            Console.WriteLine("metin p ile bitiyor mu : " + metin.EndsWith('p'));
            Console.WriteLine("metin r ile bitiyor mu : " + metin.EndsWith('r'));

            Console.WriteLine("metin s ile başlıyor mu : " + metin.StartsWith('s'));
            Console.WriteLine("metin M ile başlıyor mu : " + metin.StartsWith('M'));

            Console.WriteLine("metin IndexOf('i') : " + metin.IndexOf('i')); // metin değikeni içinde ilgili karakterin başladığı index değerini veriyor
            Console.WriteLine("metin IndexOf(\"name\") : " + metin.IndexOf("name"));
            Console.WriteLine("metin IndexOf(\"var\") : " + metin.IndexOf("var")); // eğer bulamazsa -1 değeri döndürüyor
            Console.WriteLine("metin LastIndexOf('i') : " + metin.LastIndexOf('i')); // i nin geçtiği en son index numarası
            Console.WriteLine("metin.Insert " + metin.Insert(0, "Merhaba ")); // değişkene verdiğimiz index numarasından itibaren ilgili değeri(Merhaba) ekle (insert metodu metnin değerini değiştirmez!)
            Console.WriteLine("metin: " + metin);

            Console.WriteLine("metin.Substring(2): " + metin.Substring(2)); // metnin içinde verilen indexteki karakterden itibaren kalan kısmı parçalayıp bize getirir.
            Console.WriteLine("metin.Substring(2, 5): " + metin.Substring(2, 5)); // 1. parametre metnin içinde kaçıncı sırada başlayacak, 2. parametre kaç karakter uzunluğunda parça alınsın

            Console.WriteLine("metin.ToLower() metindeki tüm karakterleri küçük harf yapar: " + metin.ToLower());
            Console.WriteLine("metin.ToUpper() metindeki tüm karakterleri büyük harf yapar: " + metin.ToUpper());
            Console.WriteLine("metin.ToLower().Replace(\" \", \"-\"): " + metin.ToLower().Replace(" ", "-")); //Replace metodu ilk parametrede gördüğü karakteri 2. parametrede verdiğimizle değiştirir. 
            Console.WriteLine("metin.Remove(2, 5) verilen indexten itibaren 5 karakteri sil: " + metin.Remove(2, 5));
            string sehirler = "İstanbul,Ankara,İzmir,Çankırı,Karabük";
            Console.WriteLine("şehirler: " + sehirler);
            string[] sehirListesi = sehirler.Split(","); // Split metodu kendisine verilen karakter ile ayrılmış olan verileri o karaktere göre parçalayıp sehirListesi dizisine atar.
            Console.WriteLine("Seçilen Şehir: " + sehirListesi[4]);
            foreach (var sehir in sehirListesi)
            {
                Console.WriteLine(sehir);
            }
        }
    }
}
