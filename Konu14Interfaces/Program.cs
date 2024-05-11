namespace Konu14Interfaces
{
    interface OrnekArayuz
    {
        public int Id { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interfaces, Arayüzler!");
            Console.WriteLine("Bir Tv kumandasının tuşları gibi class ları dizayn edebilmemizi sağlayan yapılardır.");
            Console.WriteLine("class lara benzer tanımlanırlar");
            Console.WriteLine("bir class a bir interface den kalıtım alınırsa ilgili interface içerisindeki tüm özellikler class da kullanılmak zorundadır!");
        }
    }
    interface ISinifGereksinimleri // interface lere isim verirken ilk harf I yapılmalıdır
    {
        // bu interface bir sınıfta kalıtım alınırsa aşağıdaki tüm property ler kullanılmak zorundadır. Buna implementasyon denir.
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
    interface IVeritabaniIslemleri
    {
        // bu interface bir sınıfta kalıtım alınırsa aşağıdaki tüm methodlar kullanılmak zorundadır.
        // interface lerde methodlar sadece aşağıdaki gibi tanımlanır! Metodun yapacağı iş burada değil kullanılacağı class ta yapılır!
        void Add(); // kayıt ekle metot imzası
        void Update(); // güncelle
        void Delete(); // sil
        void GetAll(); // listele
    }
    class Urun : ISinifGereksinimleri, IVeritabaniIslemleri // bu şekilde urun sınıfında ISinifGereksinimleri interfacinden kalıtım alırsak interface içindeki tüm proplar burada da yeniden tanımlanmak zorundadır.
        // ampulden implement interface e basarsak otomatik doldurur
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public string? Resim { get; set; }
        public decimal Fiyati { get; set; }
        public int Kdv { get; set; }
        public string? Aciklamasi { get; set; }

        public void Add()
        {
            Console.WriteLine("Ürün Eklendi!");
        }

        public void Delete()
        {
            Console.WriteLine("Ürün Silindi!");
        }

        public void GetAll()
        {
            Console.WriteLine("Ürünler Listelendi!");
        }

        public void Update()
        {
            Console.WriteLine("Ürün Güncellendi!");
        }
    }
}
