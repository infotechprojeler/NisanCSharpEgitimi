namespace ClassLibrary1
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; } // string? bu alanın boş bırakılabileceğini ifade eder
        public static string? StatikDeger { get; set; } // static elemeanlara direk classadı.propadı şeklinde erişebiliriz, class ı newlemeye gerek yoktur
        public List<Product>? Products { get; set; } // burada da 1 kategoriye bağlı birden fazla ürün olabileceğini ifade ettik. Böylece örneğin telefon kategorisindeki ürünleri listeleyebiliyoruz.

        // Bu projedeki class ları solution içerisindeki tüm projelerde kullanabiliriz. Bunun için bu projeyi diğer projelerden hangilerinde kullanmak istersek o projenin dependencies ine sağ tıklayıp add project reference menüsünden bağlantı kurmamız lazım.
    }
}
