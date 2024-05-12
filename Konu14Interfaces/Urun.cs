namespace Konu14Interfaces
{
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
