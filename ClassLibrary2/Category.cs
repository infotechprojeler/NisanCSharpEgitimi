using System.Collections.Generic;

namespace ClassLibrary2
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; } // kategori ve product arasında bire çok bir ilişki kurduk. 1 kategoriye ait birçok ürün olabilir demektir.
    }
}
