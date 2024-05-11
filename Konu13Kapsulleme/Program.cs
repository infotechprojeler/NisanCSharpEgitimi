namespace Konu13Kapsulleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kapsülleme-Encapsulation!");
            Console.WriteLine("Gerçek hayatta dışında kapsül içinde toz ilaç olan yapılara benzer bir sistemin yazılıma uyarlanmış halidir.");
            Console.WriteLine("Hassas veri kullanıp bu veriye dışarıdan istemediğimiz şekilde ulaşılabilmesini önlememizi sağlar.");

            Console.WriteLine();

            Bolum bolum = new Bolum();
            Console.WriteLine("Kayıt Yaptırmak İstediğiniz Bölümü Yazınız:");
            var girilenBolum = Console.ReadLine();
            var numara = 18;
            var durum = true;
            bolum.SetBolumAdi(girilenBolum);
            var sonuc = bolum.GetBolumAdi();
            // Console.WriteLine(sonuc);

            Fakulte fakulte = new Fakulte();
            fakulte.Bolum = girilenBolum;
        }
    }
    // Method Kullanarak Kapsülleme
    public class Bolum
    {
        private string BolumAdi; // sadece classtan erişebileceğimiz gizli değişkenimiz
        // Accesor-Getter
        public string GetBolumAdi() // BolumAdi değişkenindeki veriyi dışarı göndermemizi sağlayan public metodumuz.
        {
            return BolumAdi; // geriye private değişken verisini gönderiyoruz
        }
        // Mutator-Setter
        public void SetBolumAdi(string a)// private string BolumAdi na bu metotla kontrollü şekilde değer ataması yaptırıyoruz!
        {
            if (a == "Yazılım") // burası kapsülleme işleminin yapıldığı yer. Eğer istemediğim bir veri gelmişse bu blok çalışmayacak
            {
                BolumAdi = a; // eğer a parametresine gönderilen değer Yazılım a eşitse private BolumAdi değişkenine atamaya izin ver
                Console.WriteLine(a + " Eğitimine başvurunuz alınmıştır!");
            }
            // burada program ihtiyacına göre else if lerle kontroller çoğaltılabilir.
            else
            {
                Console.WriteLine(a + " Eğitimi Kurumumuzda Verilmemektedir!");
            }
        }
    }

    // Property kullanarak kapsülleme işlemi
    public class Fakulte
    {
        public int MyProperty { get; set; } // bu property yapısını açıp aşağıdaki gibi kullanabiliyoruz. Property nin değişkenden en önemli farklarından birisi bu.
        private string bolum;
        public string Bolum
        {
            get
            {
                return bolum;
            }
            set
            {
                if (value == "Yazılım" || value == "yazılım") // eğer gönderilen değer yazılım a eşitse
                {
                    bolum = value; // içerde kapsüllediğimiz bolum değişkenine değeri ata
                    Console.WriteLine("Kurumumuzdaki " + value + " Eğitimine Başvurunuz Alındı!");
                }
                else
                {
                    Console.WriteLine("Kurumumuzda " + value + " Eğitimi Verilmemektedir!");
                    return;
                }
            }
        }
    }

}
