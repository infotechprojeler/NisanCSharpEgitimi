namespace Konu12KalitimInheritance
{
    internal class Kategori : OrtakOzellikler
    {
        public string? Resim { get; set; }
        public string? Aciklamasi { get; set; }
        public bool UstMenudeGoster { get; set; }
        public bool YanMenudeGoster { get; set; }
    }
}
