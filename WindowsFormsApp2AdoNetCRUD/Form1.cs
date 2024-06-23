using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2AdoNetCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UrunDAL _urunDAL = new UrunDAL();
        private void Form1_Load(object sender, EventArgs e)
        {
            KayitListele();
        }

        void KayitListele()
        {
            //dgvUrunler.DataSource = _urunDAL.UrunleriGetir(); // dgvUrunler in içini _urunDAL nesnesi içindeki UrunleriGetir metoundan gelen veriyle doldur.
            dgvUrunler.DataSource = _urunDAL.UrunleriDatatablelaGetir(); // 2. yöntem datatable nesnesi kullanmak

            // dgvUrunler in üst satırını özelleştirme
            dgvUrunler.Columns[0].HeaderText = "Ürün No";
            dgvUrunler.Columns[1].HeaderText = "Ürün Adı";
            dgvUrunler.Columns[2].HeaderText = "Ürün Açıklaması";
            dgvUrunler.Columns[3].HeaderText = "Ürün Fiyatı";
            dgvUrunler.Columns[4].HeaderText = "Ürün Stok";

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
                var sonuc = _urunDAL.Add(new Urun
                {
                    Name = txtUrunAdi.Text,
                    Description = txtUrunAciklamasi.Text,
                    Price = decimal.Parse(txtUrunFiyati.Text),
                    Stock = Convert.ToInt32(txtUrunStok.Text),
                    IsActive = cbDurum.Checked
                });
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
            // Ekrandaki listeden seçilen satırdaki bilgileri yakalama
            /*
            txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtUrunAciklamasi.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            txtUrunFiyati.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            txtUrunStok.Text = dgvUrunler.CurrentRow.Cells[4].Value.ToString();
            */
            // Seçilen kaydın bilgisini veritabanından getirme
            int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
            var urun = _urunDAL.UrunGetir(id);

            txtUrunAdi.Text = urun.Name;
            txtUrunAciklamasi.Text = urun.Description;
            txtUrunFiyati.Text = urun.Price.ToString();
            txtUrunStok.Text = urun.Stock.ToString();
            cbDurum.Checked = urun.IsActive;

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
                var sonuc = _urunDAL.Update(new Urun
                {
                    Id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value),
                    Name = txtUrunAdi.Text,
                    Description = txtUrunAciklamasi.Text,
                    Price = decimal.Parse(txtUrunFiyati.Text),
                    Stock = Convert.ToInt32(txtUrunStok.Text),
                    IsActive = cbDurum.Checked
                });
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvUrunler.CurrentRow.Cells[0].Value);
                var sonuc = _urunDAL.Delete(id);
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
            catch
            {
                MessageBox.Show("Hata Oluştu!");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = _urunDAL.UrunleriDatatablelaGetir(txtAra.Text);
        }
    }
}
