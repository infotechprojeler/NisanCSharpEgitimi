namespace Konu18SOLIDPrensipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID Prensipleri!");
            Console.WriteLine("Robert Cecil Martin tarafından öne sürülen geliştirilecek yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını hedefleyen kod tekrarını önleyen prensipler bütünüdür.");

            Console.WriteLine("SOLID bu prensiplerin baş harflerinden oluşan kısaltmadır.");

            Console.WriteLine("S - Single Responsiblity");
            Console.WriteLine("1 sınıf veya metodun sadece 1 tane sorumluluğunun olması gerekir.");

            Console.WriteLine("O - Open-Closed Princible");
            Console.WriteLine("Bir sınıf veya metot varolan özelliklerini korumalı, değişikliğe izin vermemelidir!");

            Console.WriteLine("L - Liskov Subsitition");
            Console.WriteLine("Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları türedikleri üst sınıfların yerine kullanabilmeliyiz.");

            Console.WriteLine("I - Interface Segregation");
            Console.WriteLine("Sorumlulukların hepsini tek bir arayüzde toplamak yerine özelleştirilmiş birden fazla arayüz kullanmalıyız.");

            Console.WriteLine("D - Dependency Inversion");
            Console.WriteLine("Sınıflar arası bağımlılıklar olabildiğince az olmalıdır. Özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.");
        }
    }
}
