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

            Console.WriteLine();
            Console.WriteLine("Sisteme kaydetmek istediğiniz marka adını giriniz:");
            var markaAdi = Console.ReadLine();
            Marka marka = new Marka()
            {
                Name = markaAdi,
                Id = 1,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
            marka.Add();
            Console.WriteLine();
            marka.Ekle(marka); // ekle metodu bizden parametre olarak bir marka bekler
        }
    }
}
