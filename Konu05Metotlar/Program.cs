namespace Konu05Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methodlar!"); // WriteLine .net içerisinde bize sunulmuş bir methoddur
            Console.WriteLine("Bir işi yapan kodları bir araya getirip tekrar tekrar kullanabilmemizi sağlayan yapılardır.");
            Console.WriteLine("Dışarıdan göndereceğimiz parametre değerlerine göre de çalışabilirler.");
            Console.WriteLine("Geriye değer döndüren ve döndürmeyen metotlar olarak temelde ikiye ayrılırlar");

            Console.WriteLine("1. toplama yap metodu ToplamaYap()");
            ToplamaYap(); // metotlar çağrılmadığı sürece çalışmaz!

            Console.WriteLine("2. toplama yap metodu ToplamaYap(100, 18)");
            ToplamaYap(100, 18); // c# metoda gönderdiğimiz parametrelerden aşağıdaki metotlardan hangisini çalıştıracağını bulur

            Console.WriteLine("3. toplama yap metodu ToplamaYap()");
            ToplamaYap();

            Console.WriteLine("4. toplama yap metodu ToplamaYap(1000, 18, 200)");
            Console.WriteLine(ToplamaYap(1000, 18, 200)); // burada 3. toplama metodunun döndürdüğü değeri WriteLine içinde ekrana yazdırıyoruz.

            Console.WriteLine();
            /*
            Console.WriteLine("1. sayıyı giriniz:");
            var sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz:");
            var sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3. sayıyı giriniz:");
            var sayi3 = int.Parse(Console.ReadLine());

            var sonuc = ToplamaYap(sayi1, sayi2, sayi3); // toplama yap metodundan dönen değeri bir değişkene atadık
            Console.WriteLine(sonuc); // ve bu değişkendeki değeri ekrana yazdırdık
            */
            /*
            Console.WriteLine("Mail adresinizi giriniz:");
            var mailAdresi = Console.ReadLine();
            bool mailGonderildimi = MailGonder(mailAdresi);
            if (mailGonderildimi == true)
            {
                Console.WriteLine(mailAdresi + " adresine mailiniz gönderilmiştir..");
            }
            else
            {
                Console.WriteLine("Mail gönderilemedi!");
            }
            */
            // KdvHesapla();
            var deger = SmsKoduUret();
            Console.WriteLine("Sms Değer: " + deger);
        }

        static void ToplamaYap() // örnek metot tanımlaması. static ifadesi yukarıda kullanabilmemiz için gerekli, void ifadesi bu metodun geriye bir değer döndürmeyeceğini tek işlem yapacağını belirtir. ToplamaYap ise metodumuzun adıdır
        {
            Console.WriteLine(10 + 8);
        }
        static void ToplamaYap(int sayi1, int sayi2) // ToplamaYap metodunun 2. versiyonu parametreli olarak çalışmasını sağlar, dışarıdan gönderilecek değerleri toplayıp ekrana yazdırır. Buna method overloading denir aynı metodun farklı şekillerde çalışabilmesi.
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        static int ToplamaYap(int sayi1, int sayi2, int sayi3) // geriye değer döndüren metot
        {
            // ToplamaYap metot adının önündeki int ifadesi bu metodun geriye int veri tipinde bir değer döndüreceğini belirtir.
            Console.WriteLine();
            return sayi1 + sayi2 + sayi3; // geriye değer döndüren methodlarda en altta return ifadesi kullanıp sonrasına metodun göndereceği veri tipi neyse (int, string, bool vb) o tipte bir değer döndürmeliyiz yoksa kızarır ve hata verir.
        }
        static bool MailGonder(string email)
        {
            if (!string.IsNullOrWhiteSpace(email)) // burada IsNullOrWhiteSpace metodu .net de var olan ve string bir değişkenin boş olup olmadığını kontrol eden bir metottur
            {
                // burada .net içerisindeki mail gönderme kodları çalıştırılır
                
                return true; // işlemler tamamlandıktan sonra metot geriye true değeriyle işlem başarılı bilgisi gönderir
            }
            return false;
        }
        static void KdvHesapla()
        {
            double fiyat, kdv, toplam; // değişken tanımlarken aynı tipler için bu şekilde araya , koyarak birden fazla değişken tanımlayabiliriz.
            Console.WriteLine("Ürün fiyatını giriniz:");
            fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv miktarını giriniz:");
            var kdvMiktari = Convert.ToDouble(Console.ReadLine());
            kdv = fiyat * kdvMiktari / 100;
            toplam = fiyat + kdv;
            Console.WriteLine("Ürün kdv tutarı: " + kdv + " TL");
            Console.WriteLine("Kdv dahil fiyatı : " + toplam + " TL");
        }
        static string SmsKoduUret()
        {
            Random random = new Random(); // random sınıfı rasgele sayı üretmeyi sağlayan bir .net sınıfıdır.
            int sayi1 = random.Next(0, 9);
            int sayi2 = random.Next(0, 9);
            int sayi3 = random.Next(0, 9);
            int sayi4 = random.Next(0, 9);
            int sayi5 = random.Next(0, 9999);
            //return $"{sayi1}{sayi2}{sayi3}{sayi4}";
            return sayi5.ToString();
        }
    }
}
