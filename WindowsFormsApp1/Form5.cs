using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcı Adı : " + txtKullaniciAdi.Text + " - Şifre : " + txtSifre.Text);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbKategoriler.SelectedItem + " Kategorisine " + txtUrunAdi.Text + " Ürünü Kaydedildi!");

            // data grid view a kayıt ekleme
            dgvUrunler.ColumnCount = 3; // kaç kolon veri ekleyeceğimizi ayarladık

            // veri listesinin üst satırındaki başlıkları ayarlıyoruz
            dgvUrunler.Columns[0].Name = "Ürün Adı";
            dgvUrunler.Columns[1].Name = "Kategorisi";
            dgvUrunler.Columns[2].Name = "Fiyatı";

            // satıra yeni ürün bilgisi ekleme
            dgvUrunler.Rows.Add(cbKategoriler.SelectedItem.ToString(), txtUrunAdi.Text, txtFiyat.Text);
        }
    }
}
