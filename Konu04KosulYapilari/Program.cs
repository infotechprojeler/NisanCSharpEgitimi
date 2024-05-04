namespace Konu04KosulYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koşul Yapıları!");
            Console.WriteLine("Program yazarken duruma göre farklı akışlardan devam edebilmemizi sağlayan yapılardır");
            /*
            Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            var sayi = int.Parse(Console.ReadLine()); // Console.ReadLine() kullanıcının ekrandan yazdığı yazıyı okumayı sağlar
            if (sayi > 0)
            {
                Console.WriteLine("Girilen Sayı Pozitif");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Girilen Sayı 0");
            }
            else
            {
                Console.WriteLine("Girilen Sayı Negatif");
            }
            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            string kullaniciAdi = Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz:");
            string sifre = Console.ReadLine();
            if (kullaniciAdi == "mesut" && sifre == "123")
            {
                Console.WriteLine("Giriş Başarılı!");
                Console.WriteLine("Hoşgeldin " + kullaniciAdi);
            }
            else
            {
                Console.WriteLine("Giriş Başarısız!");
                Console.WriteLine("Girilen Bilgiler Hatalı! Lütfen Tekrar Deneyiniz..");
            }*/
            Console.WriteLine("Switch Case");
            Console.WriteLine("Tarih : " + DateTime.Now); // sistemde o andaki tarih ve saat bilgisini bu şekilde elde ediyoruz
            int ay = DateTime.Now.Month; // o andaki ay bilgisini aldık
            switch (ay) // bu yapıda ay değişkeninin değeri alınıp aşağıda case lerle deneme yanılma yöntemiyle tek tek kontrol ediliyor
            {
                case 12: // ay değeri 12-1-2 değerlerinden biriyse
                case 1:
                case 2:
                    Console.WriteLine("Mevsim Kış"); // buradaki kodu çalıştır
                    break; // ve aşağıya doğru akışı break komutuyla kır kodu çalıştırmaya devam etme
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Mevsim İlkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Mevsim Yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Mevsim Sonbahar, Pencerede damlalar..");
                    break;
                default: // default yapısı if else deki else mantığında çalışır yukardaki şartların hiçbiri tutmazsa bu blok devreye girer.
                    Console.WriteLine("Bir hata oluştu..");
                    break;
            }
        }
    }
}
