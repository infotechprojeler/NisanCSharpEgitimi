using ClassLibrary1;

namespace Konu08Siniflar
{
    class Ev // kendi sınıfımızı bu şekilde oluşturuyoruz
    {
        internal string sokakAdi; // bu sınıfta kullanmak istediğimiz değişkenler
        internal string kapiNo;
    }
    // Erişim Belirteçleri: Sınıflar ve içindeki öğelerine (metot, özellik, değişken vb) nerelerden erişilebilir veya erişilemez ayarını yapılandırmamızı sağlar.
    /*
     * Public: Erişim kısıtı yoktur, her yerden erişilebilir.
     * Protected: Ait olduğu sınıftan ve o sınıftan türetilen sınıflardan erişilebilir.
     * internal: Etkin projeye(Aynı namespace altındakiler) ait sınıflardan erişilebilir.
     * private: Yalnız bulunduğu sınıftan erişilebilir, dışarıdan erişimlere kapalıdır.
     */
    internal class Program // 1 sınıf tanımı bu şekilde 3 yapıdan oluşur. internal: erişim belirteci, class: sınıf yapısı, Program: sınıfımızın ismi
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar, Classes!");
            Ev ev = new Ev(); // bir sınıftan bir nesne oluşturma
            ev.sokakAdi = "internal sk."; // ev nesnesinin içindeki sokakadi değişkenine değer atama
            ev.kapiNo = "18";

            Console.WriteLine("ev in bulunduğu sokak : " + ev.sokakAdi); // değiken değerini ekrana yazdırma
            Console.WriteLine("Kapı No: " + ev.kapiNo);

            Ev koyEvi = new Ev(); // bir class tan 1 den fazla nesne oluşturabiliyoruz
            koyEvi.sokakAdi = "Köy yolu sk.";
            koyEvi.kapiNo = "3";

            Console.WriteLine("Köy Evi Bilgileri : " + koyEvi.sokakAdi + " " + koyEvi.kapiNo);

            Ev yazlik = new Ev() // sınıftan nesne tanımlamanın diğer yöntemi
            {
                sokakAdi = "Bodrum cad. yalıkavak", // burada bu şekilde değişkenlere değer atayabiliyoruz
                kapiNo = "3" // değişkenler arasında virgül kullanarak ayırıyoruz, en son değişkenden sonra virgüle gerek yok!
            };
            Console.WriteLine($"Beyza nın yazlik bilgileri : {yazlik.sokakAdi} {yazlik.kapiNo}");

            Kategori kategori = new Kategori();
            kategori.Adi = "Elektronik";

            Console.WriteLine("kategori.Adi =" + kategori.Adi);

            Kullanici kullanici = new Kullanici();
            kullanici.Adi = "Beyza";
            kullanici.Soyadi = "Erdem";
            kullanici.KullaniciAdi = "berdem";
            kullanici.Sifre = "be123";

            Console.WriteLine("Kullanıcı Bilgileri:");
            Console.WriteLine($"{kullanici.Adi} {kullanici.Soyadi}");
            Console.WriteLine();

            Kullanici kullanici2 = new Kullanici()
            {
                Adi = "Murat",
                Soyadi = "Yılmaz",
                Email = "my@hotmail.com"
            };
            Console.WriteLine("2. Kullanıcı Bilgileri:");
            Console.WriteLine($"{kullanici2.Adi} {kullanici2.Soyadi}\n Email: {kullanici2.Email}"); // string metin içindeki \n kodu sonrasındaki metni alt satıra geçirir
            Console.WriteLine();

            Araba araba = new Araba()
            {
                Marka = "Dacia",
                KasaTipi = "Sedan",
                Model = "Logan",
                VitesTipi = "Otomatik"
            };
            Console.WriteLine("Beyzanın Araç Bilgileri:");
            Console.WriteLine($"{araba.Marka} {araba.Model}");
            Araba yerliveMilli = new Araba()
            {
                Marka = "TOGG",
                KasaTipi = "SUV",
                Model = "T10x",
                VitesTipi = "Otomatik"
            };
            Console.WriteLine($"Yerli Araç: " + yerliveMilli.Marka + " " + yerliveMilli.Model);

            SiniftaMetotKullanimi metotKullanimi = new();
            Console.WriteLine("metotKullanimi: " + metotKullanimi.ToplamaYap(10, 8));

            Console.WriteLine();
            /*
            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            var kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz:");
            var kullaniciSifre = Console.ReadLine();

            bool sonuc = metotKullanimi.LoginKontrol(kullaniciAdi, kullaniciSifre);
            Console.WriteLine("login kontrol: " + (sonuc == true ? "Giriş Başarılı.." : "Giriş Başarısız!"));
            */
            Category category = new Category() // bu kategori classlibrary1 projesinden geliyor!
            {
                Id = 1,
                Name = "Telefon"
            };
            Console.WriteLine("Kategori Adı: " + category.Name);

            Category.StatikDeger = "static elemeanlara direk classadı.propadı şeklinde erişebiliriz, class ı newlemeye gerek yoktur";
            Console.WriteLine(Category.StatikDeger);

            Console.WriteLine();

            Product product = new Product()
            {
                Id = 1,
                Name = "Ayfon 18 plas",
                Description = "Daha büyük çentik, süper kamera"
            };
            Console.WriteLine("Ürün Adı: " + product.Name);
            Console.WriteLine("Ürün Açıklaması: " + product.Description);

        } // main metot bitişi
    } // program clası bitiş
    class Kullanici
    {
        // Property ler : prop tab tab kısayolu, sınıflarda değişkenler dışında kullanabileceğimiz değer atayıp okuma yapabileceğimiz özelliklerdir.
        public int Id { get; set; }
        public string Adi { get; set; } // bir property e dışarıdan veri atanırsa set bloğu, üzerindeki veri okunmak istenirse get bloğu çalışır.
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
    }
    class Araba
    {
        internal int Id { get; set; }
        internal string Marka;
        internal string Model;
        internal string KasaTipi;
        internal string YakitTipi;
        internal string VitesTipi;
        internal string Renk;
    }
}
