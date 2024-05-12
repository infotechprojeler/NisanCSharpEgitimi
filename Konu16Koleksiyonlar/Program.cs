using System.Collections;
using System.Collections.Specialized; // koleksiyonlar bu kütüphane altında yer alır. Bunu tanımlamazsak koleksiyonları kullanamayız hata verir!

namespace Konu16Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections, Koleksiyonlar!");
            Console.WriteLine("Farklı veri tipleriyle dizilere benzer şekilde listelere veri ekleyip bunları tutmamıza yardımcı olan ve dizilerden çok daha fazla özelliğe sahip olan yapılardır.");
            Console.WriteLine();

            // Ornek1(); // ArrayList
            // Ornek2(); // ArrayList
            // Ornek3(); // ArrayList
            // Ornek4(); // StringCollection
            // Ornek5(); // StringDictionary
            // Ornek6(); // Stack
            // Ornek7(); // Queue
            // Ornek8(); // Dictionary
            Ornek9(); // List
        }
        static void Ornek1()
        {
            Console.WriteLine("ArrayList");
            ArrayList arrayList = new ArrayList(); // diziden farklı olarak hangi tipte veriden oluşacağını belirtmeyiz
            arrayList.Add(1); // arrayList object tipinde veri alır, yani tüm veri tiplerini
            arrayList.Add(2); // dizilerde add metodu yoktur sonradan kayıt eklenmez
            arrayList.Add(3);
            Console.WriteLine("ArrayList deki ilk eleman : " + arrayList[0]);
            foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
        static void Ornek2()
        {
            Console.WriteLine("ArrayList Şehir Listesi");
            ArrayList arrayList = new ArrayList();
            arrayList.Add("İstanbul");
            arrayList.Add("Ankara");
            arrayList.Add("İzmir");
            arrayList.Add("Karabük");
            arrayList.Add("Çankırı");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("ArrayList deki ilk eleman : " + arrayList[0]);
            Console.WriteLine();
            Console.WriteLine("ArrayList de Sort() metoduyla sıralama yapabiliriz.");

            arrayList.Sort(); // listeyi sıraladık

            Console.WriteLine("Sıralanmış ArrayList Şehir Listesi");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayList.Reverse(); // tersten sıralama metodu

            Console.WriteLine("Reverse() ile Tersten Sıralanmış ArrayList Şehir Listesi");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Ornek3()
        {
            Console.WriteLine("ArrayList e farklı veri tipleriyle karışık liste yapabiliriz");
            ArrayList arrayList = new ArrayList();
            int tamsayi = 18;
            double kesirlisayi = 17.25;
            arrayList.Add(tamsayi);
            arrayList.Add(kesirlisayi);
            arrayList.Add("Ankara");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("For Döngüsü Kullanımı:");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]); // i index no, değeri kaçsa onu yazdır
            }
        }
        static void Ornek4()
        {
            Console.WriteLine("Sadece stringden oluşan liste");
            StringCollection stringListesi = new StringCollection();
            // stringListesi.Add(18); // bu tipe string dışında veri eklenemez.1
            stringListesi.Add("Adana");
            stringListesi.Add("Merkez");
            stringListesi.Add("");
            stringListesi.Add("İstanbul");
            foreach (var item in stringListesi)
            {
                Console.WriteLine(item);
            }
        }
        static void Ornek5()
        {
            Console.WriteLine("StringDictionary: Key-Value şeklinde bir satırda 2 değer kullanabilmemizi sağlar");
            StringDictionary dictionary = new StringDictionary();
            dictionary.Add("01", "Adana"); // 1. değer key(anahtar), 2. değer value(değer)
            dictionary.Add("06", "Angara");
            dictionary.Add("78", "Karabük");
            dictionary.Add("18", "Çankırı");
            dictionary.Add("34", "İstanbul");
            Console.WriteLine("Listedeki değerleri(Values) ekrana yaz: ");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Listedeki anahtarları(Keys) ekrana yaz: ");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Liste satırını ekrana yaz:");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("34 değerine sahip eleman : " + dictionary["34"]);
        }
        static void Ornek6()
        {
            Console.WriteLine("Stack Kullanımı");
            Console.WriteLine("Stack sınıfı programlamada LIFO (last in first out) kuyruğa son giren ilk çıkar mantığıyla çalışır.");
            Stack stack = new Stack(); //
            // stack.Add(); // stack yapısında listeye ekleme add ile olmaz
            stack.Push("İstanbul"); // object olarak her türlü veriyi kabul eder.
            stack.Push(34);
            stack.Push(99.90);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop()); // stack yığın şeklinde çalışır ve nesneler üst üste konmuş mantığında dizilir. Pop metodu en üstten başlayarak elemanları çeker getirir.
            }
        }
        static void Ornek7()
        {
            Console.WriteLine("Queue Kullanımı");
            Console.WriteLine("Queue sınıfı programlamada FIFO(first in first out) ilk giren ilk çıkar mantığıyla çalışır.");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Angara");
            queue.Enqueue(3);
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue()); // listeden öğeleri çekmek için Dequeue metodu kullanılır
            }
        }
        static void Ornek8()
        {
            Console.WriteLine("Dictionary");
            Console.WriteLine("Bu yapıyla key ve value veri tiplerini bizim belirleyebileceğimiz listeler oluşturabiliriz.");
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("34", "İstanbul");
            dictionary.Add("06", "Ankara");
            Console.WriteLine("book: " + dictionary["book"]); // key değerini vererek value ya ulaşabiliriz
            Console.WriteLine("dictionary.Keys: ");
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("dictionary.Values: ");
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Dictionary<int, string> dictionary2 = new(); // key olarak int, value olarak string verisi tutabileceğimiz bir liste oluşturduk.
            dictionary2.Add(01, "Adana");
            dictionary2.Add(34, "İstanbul");
            dictionary2.Add(06, "Ankara");

            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key); // listedeki key değerini yazdırdık
            }

            Console.WriteLine();

            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Value); // listedeki value bilgisi
            }

            Console.WriteLine();

            foreach (var item in dictionary2)
            {
                Console.WriteLine(item.Key + " " + item.Value); // listedeki key ve value yi aynı anda yazdık
            }
        }
        static void Ornek9()
        {
            Console.WriteLine("Liste Kullanımı");
            List<string> sehirler = new(); // List bize tanımlamış olduğumuz veri tipinde listeler oluşturmamızı sağlar.
            sehirler.Add("İstanbul"); // listenin bir string listesi olacağını belirttiğimiz için string veri ekleyebiliyoruz
            sehirler.Add("Ankara");
            sehirler.Add("İzmir");
            // sehirler.Add(18); // string listesine harici tipte veri eklenemz!
            foreach (var item in sehirler)
            {
                Console.WriteLine(item); // listedeki her bir şehri ekrana yazdır.
            }
            Console.WriteLine();

            List<User> users = new(); // boş bir user listesi oluştur
            users.Add(new User()
            {
                Email = "beyza@erdem.net",
                Id = 007,
                Name = "Beyza",
                Password = "Byz007"
            });
            users.Add(new User()
            {
                Email = "alp@aslan.net",
                Id = 01,
                Name = "Murat Yılmaz",
                Password = "Thug2534"
            });
            Console.WriteLine("Listedeki Kullanıcılar: ");
            foreach(var item in users)
            {
                Console.WriteLine($"Kullanıcı Bilgileri : Adı : {item.Name} Email {item.Email}");
            }
            List<User> kullanicilar = new()
            {
                new User()
                {
                    Id = 3,
                    Name = "Mert",
                    Password = "M126"
                },
                new User()
                {
                    Id = 18,
                    Name = "Nisa",
                    Password = "Nisa147"
                }
            };
            Console.WriteLine("kullanicilar listesi:");
            foreach (var item in kullanicilar)
            {
                Console.WriteLine($"Kullanıcı Bilgileri : No: {item.Id} Adı : {item.Name} Email {item.Password}");
            }

            Console.WriteLine();

            users.AddRange(kullanicilar); // AddRange metodu kullanicilar listesini users listesine topluca ekler

            Console.WriteLine("2 listenin birleşimi sonrası döngü:");
            foreach (User item in users)
            {
                Console.WriteLine($"Kullanıcı Bilgileri : No: {item.Id} Adı : {item.Name} Email {item.Password}");
            }
            var yeniKullanici = new User()
            {
                Id = 6, Name = "Lider", Email = "lider@liderpide.net", Password = "Lid159"
            };
            Console.WriteLine("Kullanıcı listesinde yeniKullanici var mı?");
            Console.WriteLine(users.Contains(yeniKullanici)); // Contains metodu yeniKullanici nesnesini users içinde arar bulursa true bulamazsa false döner
            users.Add(yeniKullanici); // users listesine yeniKullanici yı ekledik
            Console.WriteLine("Şimdi var mı?");
            Console.WriteLine(users.Contains(yeniKullanici));
        }
    }
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
