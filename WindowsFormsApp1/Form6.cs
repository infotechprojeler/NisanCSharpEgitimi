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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // ekrandaki numericUpDown1 in değeri değiştikçe
            label1.Font = new Font("Arial", (float)numericUpDown1.Value); // label1 in yazı fontunu numericUpDown1 in değerine ayarla
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < FontFamily.Families.Length; i++) // 50 kez dön
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name); // cihazdaki yüklü olan fontlardan domainUpDown1 e ekle
            }
            // ekrandaki combobox a sistemdeki fontları yüklüyoruz
            cbFontlar.DataSource = FontFamily.Families;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(domainUpDown1.SelectedItem.ToString(), (float)numericUpDown1.Value);
        }

        private void cbFontlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Seçilen Font : " + cbFontlar.SelectedItem);
        }
    }
}
