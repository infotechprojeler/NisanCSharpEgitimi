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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load metodu form ekrana yüklenirken çalışır
            label2.Text = "load metodu form ekrana yüklenirken çalışır";
            label2.Text += "projeye yeni bir form eklemek için projeye sağ klik add form menüsünü kullanabiliriz.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ekrandaki nesnelere çift click yaparak tıklandıklarında çalıştıracağımız kodların metodunu oluştururuz.
            label2.Text = "button1_Click çalıştı!";
            Form2 form2 = new Form2(); // Form2 sınıfından 1 nesne oluştur
            // form2.ShowDialog(); // bu nesneyi ekrana getir.
            form2.Show(); // diğer gösterim metodumuz
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close(); // bu formu kapat
        }
    }
}
