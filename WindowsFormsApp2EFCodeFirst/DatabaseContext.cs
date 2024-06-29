using System.Data.Entity; // Entity framework kullanabilmek için gerekli kütüphane
using ClassLibrary2;

namespace WindowsFormsApp2EFCodeFirst
{
    public class DatabaseContext : DbContext // Entity framework kullanabilmek için oluşturduğumuz DatabaseContext sınıfına entity framework ün dbcontext sınıfından kalıtım alıyoruz.
    {
        public virtual DbSet<Category> Categories { get; set; } // bu şekilde kaç tablomuz varsa dbset olarak classlarıyla birlikte ekliyoruz
        public virtual DbSet<Product> Products { get; set; }
    }
}
