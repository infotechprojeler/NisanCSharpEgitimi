using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu08Siniflar
{
    internal class SiniftaMetotKullanimi
    {
        string kurucuMetot; // constructor
        string sistemdekiKullaniciAdi;
        string sistemdekiSifre;
        // ctor tab kurucu metot oluşturmanın kısayolu
        public SiniftaMetotKullanimi() // kurucu metotların void veya geri dönüş değeri yoktur
        {
            kurucuMetot = "kurucu metotlar sınıftan alınan her nesne örneğinde ilk çalışan metotlardır";
            Console.WriteLine(kurucuMetot);
            Console.WriteLine();
            sistemdekiKullaniciAdi = "Admin";
            sistemdekiSifre = "Adm123";
        }
        public bool LoginKontrol(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == sistemdekiKullaniciAdi && sifre == sistemdekiSifre) // metoda dışarıdan gönderilecek değerler bunlara eşitse
            {
                return true; // girişe izin ver
            }
            return false;
        }
        public int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
