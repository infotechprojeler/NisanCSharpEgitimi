namespace Konu09StructYapilar
{
    public struct Yapi
    {
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("yapı içindeki metot çalıştı");
        }
    }
    internal class Program
    {
        struct Kimlik
        {
            public string Ad;
            public string Soyad;
            public int Yas;
            public string DogumYeri;
            public struct Adres
            {
                public int Id { get; set; }
                public string Sehir { get; set; }
                public string Mahalle { get; set; }
                public string AcikAdres { get; set; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Struct, Yapılar!");
            Console.WriteLine("Yapılar sınıflara benzer, sınıfların nesneleri bellekte heap alanında tutulurken yapılarınki stack alanında tutulur.");
            Console.WriteLine("C# ta değişkenler referans ve değer tipli olarak ikiye ayrılır");
            Console.WriteLine("Stack bölgesinde tutulan veriler değer tiplilerdir(string dışındaki veri tipleri ve bu struct nesneleri) ve işleri bittiğinde bellekten hemen atılırlar");
            Console.WriteLine("Heap bölgesinde tutulan veriler referans tiplilerdir(string ve class nesneleri) ve işleri bittiğinde bellekten hemen atılmazlar GC(garbage collector) yapısıyla bir süre sonra silinirler");

            Console.WriteLine();
            Yapi yapi = new Yapi();
            yapi.Metot();
            yapi.metin = "yapı metni";
            yapi.sayi = 18;
            Console.WriteLine("yapi.metin = " + yapi.metin);
            Console.WriteLine("yapi.sayi = " + yapi.sayi);

            Console.WriteLine();

            Kimlik kimlik = new Kimlik();
            kimlik.Ad = "Beyza";
            kimlik.Soyad = "Erdem";
            kimlik.Yas = 18;
            Console.WriteLine($"Kimlik Bilgileri:\nAd Soyad: {kimlik.Ad} {kimlik.Soyad}");
            Console.WriteLine("Yaş: " + kimlik.Yas);

            Console.WriteLine("Kişiye Ait Adres Bilgileri:");
            Kimlik.Adres adres = new()
            {
                Sehir = "Karabük",
                Mahalle = "Çukurambar mah."
            }; // kimlik nesnesinin içindeki adres nesnesine bu şekilde erişiyoruz.

            Console.WriteLine(adres.Sehir + " " + adres.Mahalle);
        }
    }
}
