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
            //dgvUrunler.DataSource = _urunDAL.UrunleriGetir(); // dgvUrunler in içini _urunDAL nesnesi içindeki UrunleriGetir metoundan gelen veriyle doldur.
            dgvUrunler.DataSource = _urunDAL.UrunleriDatatablelaGetir(); // 2. yöntem datatable nesnesi kullanmak
        }
    }
}
