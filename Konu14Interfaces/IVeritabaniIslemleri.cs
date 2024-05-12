namespace Konu14Interfaces
{
    interface IVeritabaniIslemleri
    {
        // bu interface bir sınıfta kalıtım alınırsa aşağıdaki tüm methodlar kullanılmak zorundadır.
        // interface lerde methodlar sadece aşağıdaki gibi tanımlanır! Metodun yapacağı iş burada değil kullanılacağı class ta yapılır!
        void Add(); // kayıt ekle metot imzası
        void Update(); // güncelle
        void Delete(); // sil
        void GetAll(); // listele
    }
}
