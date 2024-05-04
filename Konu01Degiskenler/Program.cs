// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Bu bizim ilk mesajımız"); // write metodu mesajları yan yana yazdırır
Console.WriteLine(); // cw yazıp tab a basarsak hızlıca Console.WriteLine kodu oluştururuz. 
Console.WriteLine(); // Bu şekilde boş bir satır bırakmış oluyoruz
Console.WriteLine("Console WriteLine metodu ekrana yazı yazdırmamızı sağlar");// WriteLine metodu mesajları ayrı satırlara yazdırır.
// Bu bir yorum satırıdır. // yazılı satır c# tarafından yorum satırı olarak değerlendirilir
// Alt satıra geçme işlemi : Üst menüden Tools > Options > Text Editor > All languages > Word wrap seçeneğine tik atıp ok ile pencereleri kapatıp çıkıyoruz.
/*
 C# ta birden fazla satırı yorum satırı olarak kullanmak için bu şekilde / * * / arasına istediğimizi yazabiliriz. Visual studio bunları kod olarak görmez ve hata vermez.
 */
Console.WriteLine();
// Tam sayılar
Console.WriteLine("Tam sayılar");

byte plakaKodu = 18;
short kisa = 123;
int tamSayi = 987654321;
long uzunTamsayi = 12345678999;

Console.WriteLine("uzun Tamsayi değeri : " + uzunTamsayi);

Console.WriteLine();

// Kesirli Sayılar
Console.WriteLine("Kesirli sayılar");

float kesirliSayi = 4.5f;
double kesirliDouble = 4.5;
decimal urunFiyati = 49900;

Console.WriteLine("urunFiyati değeri : " + urunFiyati);

Console.WriteLine();
// Karakter
Console.WriteLine("Karakter - Char");

char karakter = 'c'; // klavyeden girilen her değer bir karakterdir ve tek tırnak içerisine yazılır. Karakter tipi sadece tek değer alır.

Console.WriteLine("karakter değeri: " + karakter);

Console.WriteLine();
// string veri tipi
Console.WriteLine("string veri tipi");

string metin = "klavyedeki tüm karakterlerin yan yana dizilerek gösterilebildiği tiptir"; // türkçe karakterleri yazabiliriz
string metin_kelimesi;
metin_kelimesi = "değişken adında boşluk yerine _ kullanabiliriz.";

Console.WriteLine("metin değeri : " + metin);
Console.WriteLine("2. metin değeri : " + metin_kelimesi);

Console.WriteLine();
// bool veri tipi
Console.WriteLine("bool veri tipi 2 değer alır: True ve False");

bool islemSonucu = false;

Console.WriteLine("İşlem Sonucu {0} ikinci parametre : {1}", islemSonucu, karakter); // c# ta ekrana yazılacak yazı içerisine bu şekilde değer gönderebiliyoruz.

metin = "C# ta değişkenler referans tipli ve değer tipli olarak 2 ye ayrılır";
islemSonucu = true;

Console.WriteLine();
Console.WriteLine($"string içerisine yazdıracağımız değişkenleri $ ifadesiyle metin içerisine gönderbiliriz. Metin yeni değeri: {metin} . İşlem Sonucu : {islemSonucu}");

Console.WriteLine();
// C# ta Sabitler
Console.WriteLine("C# ta Sabitler");
Console.WriteLine("Değişkenlerin aksine uygulama içerisinde tanımlandıktan sonra değerinin değişmemesini istediğimiz veriler için sabit değerli yapıdır.");

// sabit tanımlama
const string sabit = "sabit değer";
const int kdv = 18;
const int iskonto = 20;
//kdv = 20; // sabitlerin değeri sonradan değiştirilemez!
Console.WriteLine(sabit + " kdv : " + kdv);