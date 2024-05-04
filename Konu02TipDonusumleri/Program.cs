namespace Konu02TipDonusumleri // namespace içerisinde yazdığımız kodları başka yerlerde kullanabilmek için tanımladığımız yapı
{
    internal class Program // projeyi oluşturduğumuzda varsayılan olarak eklenen sınıfımız
    {
        static void Main(string[] args) // console uygulamalarının çalıştığı ana method umuz
        {
            Console.WriteLine("Tip Donusumleri!");
            // bu kullanımda değişken vb kodlarımızı main metodu içerisine yazıyoruz.
            Console.WriteLine("Implicit Casting - Otomatik Tip Dönüşümü");
            int sayi = 18;
            double kesirliSayi = sayi; // burada int veri tipi double dan daha küçük değer aldığı için .net otomatik olarak tip dönüşümü yapar ve hata vermez.
            Console.WriteLine("sayi: " + sayi);
            Console.WriteLine("kesirliSayi: " + kesirliSayi);

            Console.WriteLine();

            Console.WriteLine("Explicit Casting - Manuel Tip Dönüşümü");
            double kesirliSayi2 = 18;
            int tamSayi = (int)kesirliSayi2; // normalde tamsayi 18 değerini alabilir fakat .net veri tipine bakarak hareket ettiği için burada sorumluluğu geliştiriciye bırakır. Biz eğer biliyorsak gelecek değeri kesirliSayi2 nin önüne (int) ifadesi ekleyerek manuel dönüşüm yaparız.

            Console.WriteLine(tamSayi);

            // visual studio da solution daki geçerli projeyi değiştirmek için ya sağ klik set as startup project diyeceğiz ya da üst menüden startın yanındaki listeden çalıştır dediğimizde açılacak projeyi seçeceğiz.

            // var anahtar kelimesi
            var sayilar = "123456"; // var yazıp değişken adını yazıp = den sonra değer ataması yaptığımızda c# sayilar isimli değişkenin int mi string mi olduğunu atanan değere bakarak otomatik belirler
            var kdv = 20; // tam sayılar için varsayılan veri tipi int
            var urunFiyati = 9990f; // sona eklediğimiz f den bu veri tipinin float olduğunu anlar
            var fiyat2 = 19.90; // double tipini kullanılan noktadan belirledi

            Console.WriteLine();
            Console.WriteLine("Ürün Fiyatı : " + urunFiyati + " TL");

            Console.WriteLine();

            Console.WriteLine("Parse Metotlarıyla Dönüştürme:");

            Console.WriteLine("int.Parse yöntemiyle string içindeki değeri sayıya dönüştürebiliriz : " + int.Parse(sayilar));
            Console.WriteLine("sayilar içindeki değeri double.Parse ile double a dönüştür : " + double.Parse(sayilar));
            Console.WriteLine("sayilar içindeki değeri decimal.Parse ile decimal e dönüştür : " + decimal.Parse(sayilar));

            // Convert Metotları
            Console.WriteLine("Convert Metotlarıyla Dönüştürme:");
            Console.WriteLine("Convert.ToInt32-string içindeki sayısal değeri int e çevirme : " + Convert.ToInt32(sayilar));
            Console.WriteLine("Convert.ToDouble-string içindeki sayısal değeri Double a çevirme : " + Convert.ToDouble(sayilar));
            Console.WriteLine("Convert.ToDecimal-string içindeki sayısal değeri Decimal e çevirme : " + Convert.ToDecimal(sayilar));

        } // main metodunun bittiğini gösteren süslü parantez
    } // program class ının bitişi
} // namespace bloğunun bitişi
