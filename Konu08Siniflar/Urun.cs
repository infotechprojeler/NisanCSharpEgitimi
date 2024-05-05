namespace Konu08Siniflar
{
    internal class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklamasi { get; set; }
        public decimal Fiyati { get; set; }
    }
    partial class UrunOzellik // urun sınıfını bu şekilde partial(parça) mantığıyla bölebiliyoruz
    {
        public int Id { get; set; }
        public string Adi { get; set; } = string.Empty;
        public string? Rengi { get; set; }
        public string? Olculeri { get; set; }
    }
}
