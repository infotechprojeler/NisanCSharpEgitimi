namespace Konu15AbstractSiniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract, Sınıflar!");
            Console.WriteLine("Abstract classlar hem class hem de interface özelliklerine sahip yapılardır");
            Console.WriteLine("Dolayısıyla içinde hem metot imzası hem de metot tanımlayabiliriz.");
            Console.WriteLine("Class larda metot imzası tanımlayamayız ama metot tanımlayabiliriz");
            Console.WriteLine("Interface lerde metot imzası tanımlayabiliriz ama metot tanımlayamayız");
            Console.WriteLine("Sınıflarda new ile nesneler oluşturabiliriz fakat abstract sınıflar sadece kalıtım amaçlı geliştirildiği için new ile nesne oluşturamazlar.");
            Console.WriteLine("Bir sınıfa sadece 1 tane abstract sınıf inherit edilebilir fakat bir sınıfa birden fazla interface inherit edilebilir(yani 1 sınıf birden fazla interface den kalıtım alabilir.)");

            Console.WriteLine();

            // abstract class tan nesne oluşturma
            // Database database = new Database(); // abstract class bu şekilde direk nesne oluşturmaya izin vermez!
            Console.WriteLine("SqlServer veritabanı işlemleri");
            Database database = new SqlServer(); // abstract class larda nesneyi bu şekilde oluşturabiliriz!
            database.Add();
            database.Update(18); // methodu id ile çalışır yaptığımız için güncellemek istediğimiz kayıt numarasını bu şekilde parametre olarak yollamak zorundayız yoksa hata alırız!

            Console.WriteLine();

            Console.WriteLine("MySql veritabanı işlemleri");
            Database database2 = new MySql();
            database2.Add();
            database2.Delete(18);
        }
    }
    abstract class Database
    {
        public void Add() // class lardaki gibi normal method ekleme
        {
            Console.WriteLine("Ekleme metodu çalıştı");
        }
        public abstract void Delete(int id); // abstract class ta interface gibi method imzası tanımlama
        public abstract void Update(int id);
        public abstract void Get(int id);
    }
    class SqlServer : Database // SqlServer veritabanı kayıt işlemleri yapan bir sınıftır ve ana database sınıfındaki method imzalarına ait metotları kullanmak zorundadır.
    {
        public override void Delete(int id)
        {
            Console.WriteLine("SqlServer dan " + id + " numaralı kayıt silindi!");
        }

        public override void Get(int id)
        {
            Console.WriteLine("SqlServer dan " + id + " numaralı kayıt getirildi!");
        }

        public override void Update(int id)
        {
            Console.WriteLine("SqlServer da " + id + " numaralı kayıt güncellendi!");
        }
    }
    class MySql : Database
    {
        public override void Delete(int id)
        {
            Console.WriteLine("MySql dan " + id + " numaralı kayıt silindi!");
        }

        public override void Get(int id)
        {
            Console.WriteLine("MySql dan " + id + " numaralı kayıt getirildi!");
        }

        public override void Update(int id)
        {
            Console.WriteLine("MySql da " + id + " numaralı kayıt güncellendi!");
        }
    }
}
