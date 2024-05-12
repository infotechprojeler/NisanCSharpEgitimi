
namespace Konu14Interfaces
{
    internal class Marka : ISinifGereksinimleri, IVeritabaniIslemleri
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public void Ekle(Marka marka)
        {
            if (marka != null)
            {
                Console.WriteLine("Marka Eklendi!");
                Console.WriteLine("Eklenen Marka Bilgileri:");
                Console.WriteLine("Adı: " + marka.Name);
                Console.WriteLine("No: " + marka.Id);
                Console.WriteLine("Eklenme Tarihi: " + marka.CreateDate);
                Console.WriteLine("Son Güncellenme Tarihi: " + marka.UpdateDate);
            }
            else
                Console.WriteLine("Marka Eklenemedi!");
        }

        public void Add()
        {
            Console.WriteLine("Marka Eklendi!");
        }

        public void Delete()
        {
            Console.WriteLine("Marka Silindi!");
        }

        public void GetAll()
        {
            Console.WriteLine("Marka Listelendi!");
        }

        public void Update()
        {
            Console.WriteLine("Marka Güncellendi!");
        }
    }
}
