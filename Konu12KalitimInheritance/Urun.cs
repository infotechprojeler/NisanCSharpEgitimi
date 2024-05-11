namespace Konu12KalitimInheritance
{
    internal class Urun : OrtakOzellikler // bu şekilde OrtakOzellikler classındaki tüm property ler Urun classındaymış gibi kullanılabilir Urun sınıfından nesne oluşturacağımız yerde.
    {
        public string? Resim { get; set; }
        public decimal Fiyati { get; set; }
        public int Kdv { get; set; }
        public string? Aciklamasi { get; set; }
    }
}
