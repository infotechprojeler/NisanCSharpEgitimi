using ClassLibrary2;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2EFCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext(); // EF tablolarımızın olduğu sınıftan nesne oluşturuyoruz.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Projede entity framework kullanabilmek için microsoftun nuget kütüphanesinden ilgili paketi yüklememiz gerekiyor.
            // Bunun için projeye sağ tıklayıp manage nuget packages menüsüne tıklayıp açılan ekrandan entity framework ü projemize yüklememiz gerekir
            KayitListele();
        }
        void KayitListele()
        {
            dgvUrunler.DataSource = context.Products.ToList(); // yukarda oluşturduğumuz context nesnesi içinde yer alan products tablosuna bağlan ve kayıtları listele
            cbKategoriler.DataSource = context.Categories.ToList();
            cbKategoriler.DisplayMember = "Name";
            cbKategoriler.ValueMember = "Id";

            // dgvUrunler in üst satırını özelleştirme
            dgvUrunler.Columns[0].HeaderText = "Ürün No";
            dgvUrunler.Columns[1].HeaderText = "Ürün Adı";
            dgvUrunler.Columns[2].HeaderText = "Ürün Açıklaması";
            dgvUrunler.Columns[3].HeaderText = "Ürün Fiyatı";
            dgvUrunler.Columns[4].HeaderText = "Ürün Stok";
            dgvUrunler.Columns[5].HeaderText = "Durum";

            // textboxları temizle
            txtUrunAciklamasi.Text = "";
            txtUrunAdi.Text = string.Empty;
            txtUrunFiyati.Text = string.Empty;
            txtUrunStok.Text = string.Empty;

            // gereksiz butonları pasife al
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || string.IsNullOrWhiteSpace(txtUrunFiyati.Text) || string.IsNullOrWhiteSpace(txtUrunStok.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
                return;
            }
            try
            {
                context.Products.Add(new Product
                {
                    Name = txtUrunAdi.Text,
                    Description = txtUrunAciklamasi.Text,
                    Price = decimal.Parse(txtUrunFiyati.Text),
                    Stock = Convert.ToInt32(txtUrunStok.Text),
                    IsActive = cbDurum.Checked,
                    CategoryId = (int)cbKategoriler.SelectedValue
                });
                var sonuc = context.SaveChanges(); // entity framework de kayıt işini tamamlamayı SaveChanges metodu yapar ve bize etkilenen kayıt sayısını döndürür.
                if (sonuc > 0)
                {
                    KayitListele();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!");
                }
            }
            catch (Exception hata)
            {
                // burada hata nesnesini veritabaında loglayabiliriz
                MessageBox.Show("Hata Oluştu!" + hata);
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen kaydın bilgisini veritabanından getirme
            int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
            var urun = context.Products.Find(id); // EF de find metodu ile id ye göre kayıt buluyoruz

            txtUrunAdi.Text = urun.Name;
            txtUrunAciklamasi.Text = urun.Description;
            txtUrunFiyati.Text = urun.Price.ToString();
            txtUrunStok.Text = urun.Stock.ToString();
            cbDurum.Checked = urun.IsActive;
            cbKategoriler.SelectedValue = urun.CategoryId;

            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || string.IsNullOrWhiteSpace(txtUrunFiyati.Text) || string.IsNullOrWhiteSpace(txtUrunStok.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz!");
                return;
            }
            try
            {
                int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
                var urun = context.Products.Find(id);

                urun.Name = txtUrunAdi.Text;
                urun.Description = txtUrunAciklamasi.Text;
                urun.Price = decimal.Parse(txtUrunFiyati.Text);
                urun.Stock = Convert.ToInt32(txtUrunStok.Text);
                urun.IsActive = cbDurum.Checked;
                urun.CategoryId = (int)cbKategoriler.SelectedValue;

                var sonuc = context.SaveChanges(); // entity framework de kayıt işini tamamlamayı SaveChanges metodu yapar ve bize etkilenen kayıt sayısını döndürür.
                if (sonuc > 0)
                {
                    KayitListele();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
                var urun = context.Products.Find(id);

                context.Products.Remove(urun); // bu ürünü veritabanından sil
                var sonuc = context.SaveChanges(); // entity framework de kayıt işini tamamlamayı SaveChanges metodu yapar ve bize etkilenen kayıt sayısını döndürür.
                if (sonuc > 0)
                {
                    KayitListele();
                    MessageBox.Show("Kayıt Silme Başarılı!");
                }
                else
                {
                    MessageBox.Show("Kayıt Silme Başarısız!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu!" + hata);
            }
        }
    }
}
