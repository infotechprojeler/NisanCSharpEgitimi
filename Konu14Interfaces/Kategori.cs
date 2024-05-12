namespace Konu14Interfaces
{
    internal class Kategori : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public string? Description { get; set; }
        public string? KategoriBanner { get; set; }
        public bool UstMenudeGoster { get; set; }

        public void Add()
        {
            Console.WriteLine("Kategori Eklendi!");
        }

        public void Delete()
        {
            Console.WriteLine("Kategori Silindi!");
        }

        public void GetAll()
        {
            Console.WriteLine("Kategoriler Listelendi!");
        }

        public void Update()
        {
            Console.WriteLine("Kategori Güncellendi!");
        }
    }
}
