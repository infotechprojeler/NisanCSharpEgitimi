namespace Konu14Interfaces
{
    interface ISinifGereksinimleri // interface lere isim verirken ilk harf I yapılmalıdır
    {
        // bu interface bir sınıfta kalıtım alınırsa aşağıdaki tüm property ler kullanılmak zorundadır. Buna implementasyon denir.
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
