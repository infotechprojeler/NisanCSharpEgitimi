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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // timer ı form açılışında aktif etme
            timer1.Enabled = true; // timer varsayılan olarak kapalıdır ya burada ya da ön yüzde aktif etmeliyiz
            timer1.Interval = 1000; // milisaniye = 1 saniyede 1 çalışsın
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ön yüzdeki timer1 e çift tıkladığımızda bu metot oluşur ve ayarladığımız süreye göre saatin tiktak mantığıyla çalışır ve buradaki kodları çalıştırır.
            Random random = new Random(); // rasgele sayı üreten c# sınıfımız
            this.BackColor = Color.FromArgb(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100)); // 1. değer red, 2. green, 3. blue
        }
    }
}
