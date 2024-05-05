using System.ComponentModel;

namespace Konu11Enumlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumlar!");
            Console.WriteLine("Projelerimizde sabit olan ve proje genelinde kullanabileceğimiz nesnelerdir. Projeye giriş yapan yönetici rolü, sipariş durumu vb gibi genel kullanımlarda işe yarar.");
            Console.WriteLine();
            byte a = (byte)Meyveler.Armut; // burada armut un sıra numarasına ulaşmak için casting işlemi yapılıyor
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine("Meyveler.Armut: " + Meyveler.Armut);
            Console.WriteLine("Meyveler.Armut(a): " + a);
            Console.WriteLine("Meyveler.Çilek: " + Meyveler.Çilek);
            Console.WriteLine("Meyveler.Armut(c): " + c);
            Console.WriteLine();

            SiparisKontrol(2);
            Console.WriteLine();
            SiparisKontrol2(4);

            Console.WriteLine();
            Console.WriteLine(UserType.SuperAdmin);
            Console.WriteLine();
        }
        enum Aylar : byte // aylar byte veri tipinde numaralansın
        {
            Ocak, Şubat, Mart
        }
        enum SiparişDurumu
        {
            Hazırlanıyor, Hazırlandı, KargoBekleniyor, Kargolandı, TeslimEdildi
        }
        enum Meyveler : int // Meyveler int veri tipinde numaralansın
        {
            Elma = 3, Armut = 7, Çilek = 1
        }
        static void SiparisKontrol(int siparisDurum)
        {
            if (siparisDurum == (int)SiparişDurumu.Hazırlanıyor)
            {
                Console.WriteLine("Sipariş Durumu : Hazırlanıyor");
            }
            if (siparisDurum == (int)SiparişDurumu.Hazırlandı)
            {
                Console.WriteLine("Sipariş Durumu : Hazırlandı");
            }
            if (siparisDurum == (int)SiparişDurumu.KargoBekleniyor)
            {
                Console.WriteLine("Sipariş Durumu : Kargo Bekleniyor");
            }
            if (siparisDurum == (int)SiparişDurumu.Kargolandı)
            {
                Console.WriteLine("Sipariş Durumu : Kargoya Verildi");
            }
            if (siparisDurum == (int)SiparişDurumu.TeslimEdildi)
            {
                Console.WriteLine("Sipariş Durumu : Teslim Edildi");
            }
        }
        static void SiparisKontrol2(int siparisDurum)
        {
            switch (siparisDurum)
            {
                case (int)SiparişDurumu.Hazırlanıyor:
                    Console.WriteLine("Sipariş Durumu : Hazırlanıyor");
                    break;
                case (int)SiparişDurumu.Hazırlandı:
                    Console.WriteLine("Sipariş Durumu : Hazırlandı");
                    break;
                case (int)SiparişDurumu.KargoBekleniyor:
                    Console.WriteLine("Sipariş Durumu : Kargo Bekleniyor");
                    break;
                case (int)SiparişDurumu.Kargolandı:
                    Console.WriteLine("Sipariş Durumu : Kargolandı");
                    break;
                case (int)SiparişDurumu.TeslimEdildi:
                    Console.WriteLine("Sipariş Durumu : Teslim Edildi");
                    break;
                default:
                    Console.WriteLine("Bilinmiyor!");
                    break;
            }
        }
        public enum UserType
        {
            [Description("Süper Admin")]
            SuperAdmin = 1,
            [Description("İşveren")]
            Employer,
            [Description("Çalışan")]
            Employee
        }
    }
}
