﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data; // sql veritabanı işlemleri yapmamızı sağlayan kütüphane
using System.Data.SqlClient; // ado.net kütüphanesi

namespace WindowsFormsApp2AdoNetCRUD
{
    public class UrunDAL // bu class urun ile ilgili veritabanı işlemleri yapacağımız class. DAL: Data Access Layer ın kısaltması, veri erişim katmanı diye çevrilebilir.
    {
        SqlConnection _connection = new SqlConnection(@"server=.; database=AdoNetDb; trusted_connection=true;"); // SqlConnection sınıfı veritabanı bağlantısını kurabilmemizi sağlayan sınıftır. Parametre olarak bağlanacağı server adresini alır.
        void BaglantiyiAc()
        {
            if (_connection.State == ConnectionState.Closed) // eğer yukardaki sql _connection nesnesi server a bağlı değilse,
                _connection.Open(); // bağlantıyı kur.
        }
        public List<Urun> UrunleriGetir()
        {
            List<Urun> urunler = new List<Urun>(); // geriye döndürmek için boş bir ürün listesi oluşturduk
            BaglantiyiAc(); // eğer bağlantı kapalıysa açacak olan metodu çağırıyoruz.
            SqlCommand sqlCommand = new SqlCommand("select * from Urunler", _connection); // sql komutu çalıştırmamızı sağlayan ado net nesnesi oluşturuyoruz. Bu nesne 2 parametre alıyor 1. si çalıştıracağımız sql komutu, 2. si bu komutun çalıştırılacağı server ve veritabanı
            SqlDataReader reader = sqlCommand.ExecuteReader(); // sqlCommand içerisinde çalıştırılan sql sorgusundan dönen veriyi okumak için reader nesnesi oluşturduk
            while (reader.Read()) // while döngüsüyle reader da okunacak kayıt bulduğu sürece döngü dönmeye devam eder
            {
                Urun urun = new Urun()
                {
                    Id = (int)reader["Id"],
                    Description = (string)reader["Description"],
                    Name = (string)reader["Name"],
                    Price = Convert.ToDecimal(reader["Price"]),
                    Stock = Convert.ToInt32(reader["Stock"]),
                    IsActive = reader.GetBoolean(5)
                };
                urunler.Add(urun); // db den gelen ürünü yukardaki boş listeye ekliyoruz.
            }
            reader.Close(); // reader ı kapat
            sqlCommand.Dispose(); // sqlCommand ı patlat
            _connection.Close(); // bağlantıyı uçur.
            return urunler; // metot geriye ürün listesi döndüreceği için yukardaki listeyi döndürüyoruz.
        }
        public DataTable UrunleriDatatablelaGetir()
        {
            DataTable dt = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from urunler", _connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dt.Load(reader); // reader dan okunan verileri data tabloya yüklüyoruz
            reader.Close();
            sqlCommand.Dispose();
            _connection.Close();
            return dt;
        }
        public DataTable UrunleriDatatablelaGetir(string kelime) // üstteki metodun aynısının overload u
        {
            DataTable dt = new DataTable();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from urunler where Name like @kelime", _connection);
            sqlCommand.Parameters.AddWithValue("@kelime", "%" + kelime + "%");
            SqlDataReader reader = sqlCommand.ExecuteReader();
            dt.Load(reader); // reader dan okunan verileri data tabloya yüklüyoruz
            reader.Close();
            sqlCommand.Dispose();
            _connection.Close();
            return dt;
        }
        public int Add(Urun urun)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("insert into Urunler (Name, Price, Stock, Description, IsActive) values (@Name, @Price, @Stock, @Description, @IsActive)", _connection);
            sqlCommand.Parameters.AddWithValue("@Name", urun.Name);
            sqlCommand.Parameters.AddWithValue("@Price", urun.Price);
            sqlCommand.Parameters.AddWithValue("@Stock", urun.Stock);
            sqlCommand.Parameters.AddWithValue("@Description", urun.Description);
            sqlCommand.Parameters.AddWithValue("@IsActive", urun.IsActive);
            islemSonucu = sqlCommand.ExecuteNonQuery(); // sqlCommand ın içindeki ExecuteNonQuery metodu bize etkilenen satır sayısını verir
            sqlCommand.Dispose();
            _connection.Close();
            return islemSonucu;
        }
        public int Update(Urun urun)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("update Urunler set Name=@Name, Price=@Price, Stock=@Stock, Description=@Description, IsActive=@IsActive where Id=@UrunId", _connection);
            sqlCommand.Parameters.AddWithValue("@UrunId", urun.Id); // where şartı için bu satırı ekliyoruz
            sqlCommand.Parameters.AddWithValue("@Name", urun.Name);
            sqlCommand.Parameters.AddWithValue("@Price", urun.Price);
            sqlCommand.Parameters.AddWithValue("@Stock", urun.Stock);
            sqlCommand.Parameters.AddWithValue("@Description", urun.Description);
            sqlCommand.Parameters.AddWithValue("@IsActive", urun.IsActive);
            islemSonucu = sqlCommand.ExecuteNonQuery(); // sqlCommand ın içindeki ExecuteNonQuery metodu bize etkilenen satır sayısını verir
            sqlCommand.Dispose();
            _connection.Close();
            return islemSonucu;
        }
        public int Delete(int id)
        {
            BaglantiyiAc();
            int islemSonucu = 0;
            SqlCommand sqlCommand = new SqlCommand("delete from Urunler where Id=@UrunId", _connection);
            sqlCommand.Parameters.AddWithValue("@UrunId", id); // where şartı için bu satırı ekliyoruz

            islemSonucu = sqlCommand.ExecuteNonQuery(); // sqlCommand ın içindeki ExecuteNonQuery metodu bize etkilenen satır sayısını verir
            sqlCommand.Dispose();
            _connection.Close();
            return islemSonucu;
        }
        public Urun UrunGetir(int id)
        {
            Urun urun = new Urun();
            BaglantiyiAc();
            SqlCommand sqlCommand = new SqlCommand("select * from urunler where Id=@UrunId", _connection);
            sqlCommand.Parameters.AddWithValue("@UrunId", id);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                urun.Id = reader.GetInt32(0);
                urun.Name = reader.GetString(1);
                urun.Description = reader.GetString(2);
                urun.Price = reader.GetDecimal(3);
                urun.Stock = reader.GetInt32(4);
                
                urun.IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;
            }
            reader.Close();
            sqlCommand.Dispose();
            _connection.Close();
            return urun;
        }
    }
}
