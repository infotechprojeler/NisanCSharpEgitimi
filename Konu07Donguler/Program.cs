namespace Konu07Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Döngüler!");
            Console.WriteLine("1-For Döngüsü");
            for (int i = 1; i <= 10; i++) // döngü tanımlama 3 bloktan oluşuyor.
                                         // int i = 0; bildiğimiz değişken tanımlama. i < 10;
                                         // i nin değeri 10 sayısından küçük olduğu sürece dönmeye devam et.
                                         // i++ : döngü her döndüğünde i nin değerini 1 artır ki sonsuz döngü olmasın
            {
                Console.WriteLine("i nin değeri : " + i);
            }

            Console.WriteLine();

            Console.WriteLine("2-While Döngüsü");
            int j = 0; // değişkeni dışarıda tanımlıyoruz
            while (j < 5) // j nin değeri 5 den küçük olduğu sürece döngü çalışacak
            {
                Console.WriteLine("j nin değeri : " + j); // j nin değerini yazdırdık
                j++; // sonsuz döngüye girmemek için j yi her dönüşte 1 artırıyoruz
            }
            Console.WriteLine();

            Console.WriteLine("3-Do While Döngüsü");
            int toplam = 10; // değişkeni döngü dışında tanımlıyoruz
            do
            {
                Console.WriteLine("toplamin değeri : " + toplam); // do kısmı her halükarda 1 kere çalışır, şarta uyulmasa bile. önce buradaki kodlar çalışır
            } while (toplam < 10); // sonra şarta bakar.

            Console.WriteLine();

            Console.WriteLine("4-Foreach Döngüsü");
            // Dizi veya liste formatındaki verileri yazdırmak için kullanılır
            string[] kategoriler = { "Elektronik", "Bilgisayar", "Telefon", "Televizyon", "Mobilya" };
            foreach (string k in kategoriler)
            {
                // Console.WriteLine("Kategori Adı : " + k);
                Console.Write(k + " ");
            }
            Console.WriteLine();

            Console.WriteLine("İç İçe Döngü:");
            string[] urunler = { "ürün 1", "ürün 2", "ürün 3" };
            foreach (string k in kategoriler) // kategori listesinde dön
            {
                Console.WriteLine(k); // kategoriyi ekrana yazdır
                foreach (var urun in urunler) // ekrana yazılan kategoriye ait ürünlerde dön
                {
                    Console.WriteLine(urun); // ilgili kategoriye ait ürünleri alt alta yazdır
                }
            }
        }
    }
}
