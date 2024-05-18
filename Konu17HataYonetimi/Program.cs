namespace Konu17HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hata, Yönetimi!");
            Console.WriteLine(".net içerisinde programımız çalışırken veri ve tipleriyle çalışırken sıklıkla hatalarla karşılaşabiliriz. Bu gibi durumlarda oluşan hatayı yakalama, gerekirse bir yere kaydetme, hata durumlarında yazılımcıya vb bildirim gönderme gibi işlemleri yapabileceğimiz bir sistem mevcuttur.");

            Console.WriteLine("Hesaplanacak Değeri Giriniz :");
            var deger = Console.ReadLine();

            // KdvHesapla(double.Parse(deger)); // eğer ekrandan kullanıcı sadece sayısal değer değil string TL gibi bir değer de gönderirse uygulama çöker! Bunu engellemek için programlamada try catch yapısı kullanılır.
            try // try yazıp 2 kere tab tuşuna basarak oluşturabiliyoruz
            {
                // uygulama çalıştığında önce buradaki try bloğu içerisindeki kodları çalıştırmayı dener
                // eğer bir hata yoksa uygulama çalışmasına devam eder
                KdvHesapla(double.Parse(deger)); // metot çalıştığında bir hata oluşursa bu sefer catch bloğu çalıştırılır.
            }
            catch (Exception hata) // oluşan hatayı bu şekilde hata nesnesiyle yakalarız
            {
                // burada yakaladığımız hata ile ne yapmak istersek o işlemi yapabiliriz
                // hata oluştuğunda sadece uygulama çöküşünü engellemek istersek herhangi bir işlem yapmamıza gerek yok
                // throw; // throw kodu hata fırlatmayı sağlar, eğer hata fırlatmak istemiyorsak bu satırı kaldırmalıyız!
                Console.WriteLine("Bir Hata Oluştu!");
                Console.WriteLine("Lütfen sadece sayısal değer girerek tekrar deneyiniz!");
                Console.WriteLine(hata.Message); // istersek hata mesajını ekrana bastırabiliriz
                try
                {
                    HatayiLogla(hata); // hatayı loglayacağımız metodu birçok hata alanında kullanabiliriz
                }
                catch{
                    // eğer hatayı loglarken de hata alırsak sadece uygulama çökmesini engelle ve uygulama çalışmasına devam etsin
                }
                
            }
            finally
            {
                Console.WriteLine("try catch bloğundan sonra her seferinde çalışmasını istediğimiz bir işlem varsa bu blokta çalıştırabiliriz. Kullanımı zorunlu değildir.");
            }
        }
        static void HatayiLogla(Exception exception)
        {
            // burada gelen exception nesnesinin detaylarını veya kendisini veritabanındaki bir tabloya kaydedebiliriz
            // veya txt dosyası olarak uygulamanın çalıştığı cihaza kaydedebiliriz
            // oluşan hata bilgilerini uygulama ekibine maille hemen bildirebiliriz
            // bu işlemlere hata loglama denir
            Console.WriteLine();
            Console.WriteLine("Detaylı hata bilgileri:");
            Console.WriteLine("exception.Message: " + exception.Message);
            Console.WriteLine();
            Console.WriteLine("exception.InnerException: " + exception.InnerException);
            Console.WriteLine();
            Console.WriteLine("exception.Source: " + exception.Source);
            Console.WriteLine();
            Console.WriteLine("exception.HResult: " + exception.HResult);
            Console.WriteLine();
            Console.WriteLine("exception.StackTrace: " + exception.StackTrace);
            Console.WriteLine();
            Console.WriteLine("exception.TargetSite: " + exception.TargetSite);
            Console.WriteLine();
            Console.WriteLine("exception.HelpLink: " + exception.HelpLink);
            Console.WriteLine();
            Console.WriteLine("exception: " + exception);
        }
        static void KdvHesapla(double fiyat)
        {
            Console.WriteLine("Fiyat : " + fiyat + " TL");
            Console.WriteLine("Kdv : " +  (fiyat * 0.20) + " TL");
            Console.WriteLine("Kdv Dahil Ödenecek Toplam Tutar : " + (fiyat + (fiyat * 0.20)) + " TL");
        }
    }
}
