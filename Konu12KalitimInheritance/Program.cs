namespace Konu12KalitimInheritance
{
    class Arac
    {
        public string AracTuru;
        public void KornaCal()
        {
            Console.WriteLine(AracTuru + " kornasına basıldı!");
        }
    }
    class Otomobil : Arac // Otomobil classına Arac classından miras aldık
    {
        public string Marka { get; set; }
        public string Model { get; set; }
    }
    class Tren
    {
        public int TrenNo { get; set; }
        public int VagonSayisi { get; set;}
    }
    class Vapur : Arac
    {
        public string GemiAdi { get; set; }
        public int GemiNo { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalıtım, Inheritance!");
            Console.WriteLine("Sınıflarda bir class taki method, property, değişken vb gibi özellikleri bir başka class a devredebilme özelliği vardır. Böylece ortak nesneleri bir sınıfa koyup oradan alacağımız kalıtım ile alt sınıflarda aynı nesneleri tekrar yazmaktan kurtuluruz.");
            #region KalıtımKodBölgesi
            // bu şekilde kodlarımızı yaptığı işe göre bloklara ayırabiliyoruz
            Arac arac = new Arac();
            arac.AracTuru = string.Empty;
            arac.KornaCal();

            Console.WriteLine();

            Otomobil otomobil = new Otomobil();
            otomobil.Marka = "TOGG";
            otomobil.AracTuru = otomobil.Marka + " SUV"; // AracTuru de Arac sınıfından gelir
            otomobil.KornaCal(); // buradaki KornaCal metodu Arac sınıfından gelir

            Console.WriteLine();

            Tren tren = new Tren();
            tren.TrenNo = 001;
            tren.VagonSayisi = 8;
            // tren.KornaCal(); treni arac sınıfından kalıtmazsak bu metoda ulaşamayız

            Console.WriteLine();

            Vapur vapur = new()
            {
                AracTuru = "Vapur",
                GemiAdi = "Paşabahçe",
                GemiNo = 18
            };
            Console.WriteLine($"Vapur Bilgileri : Gemi No : {vapur.GemiNo}");
            Console.WriteLine("Gemi Adı : " + vapur.GemiAdi);
            vapur.KornaCal(); // Vapur u da arac sınıfından miras aldırdığımız için metodu kullanabiliyoruz

            Console.WriteLine();

            Kategori kategori = new Kategori();
            kategori.Name = "Telefon";
            kategori.Aciklamasi = "Kıpraşımlı";
            kategori.CreateDate = DateTime.Now;
            Console.WriteLine("Kategori : " + kategori.Name);

            Console.WriteLine();

            Marka marka = new Marka()
            {
                Name = "Samsung",
                IsActive = true,
                Logo = "/Resimler/samsung.png"
            };
            Console.WriteLine("Marka : " + marka.Name);

            Console.WriteLine();

            Urun urun = new()
            {
                Id = 1,
                Name = "S18 Telefon",
                Fiyati = 18000,
                Kdv = 20,
                IsActive = true, // ürün pasife çekilmiş mi yoksa aktif mi
                Aciklamasi = "Samsun galaksi es 18"
            };
            if (urun.IsActive == true && urun.IsDelete == false) // eğer ürün silinmemiş ve kullanıma açıksa
            {
                Console.WriteLine("Ürün Detayı:");
                Console.WriteLine("Ürün Adı : " + urun.Name);
                Console.WriteLine("Ürün Açıklaması : " + urun.Aciklamasi);
            }
            #endregion

            Console.WriteLine();

            #region PolimorpizmOrnekleri
            Cizici cizici = new Cizici();
            // cizici.Ciz();
            Cizici[] birCizici = new Cizici[4]; // 4 elemanlı bir dizi
            birCizici[0] = new Cizici(); // her bir elemanı ayrı classtan
            birCizici[1] = new DogruCiz();
            birCizici[2] = new DaireCiz();
            birCizici[3] = new KareCiz();
            foreach (var item in birCizici)
            {
                item.Ciz(); // dizideki her nesnenin içindeki ciz metodunu çalıştır
            }
            #endregion
        }
    }
    // Polimorpizm-Çokbiçimlilik
    // Bir metodun ezilerek farklı çıktılar üretebilmesini sağlama yöntemi
    internal class Cizici
    {
        public virtual void Ciz() // normal void bir metoda ekstra virtual ifadesi ekledik, böylece bu metot farklı yerlerde ezilebilir ve farklı çıktılar üretebilir hale geldi.
        {
            Console.WriteLine("Ciz metodu çalıştı"); // Ciz metdou normalde ekrana bu çıktıyı veriyor.
        }
    }
    internal class DogruCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("DogruCiz metodu çalıştı");
        }
    }
    internal class DaireCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("DaireCiz metodu çalıştı");
        }
    }
    internal class KareCiz : Cizici
    {
        public override void Ciz()
        {
            Console.WriteLine("KareCiz metodu çalıştı");
        }
    }
}
