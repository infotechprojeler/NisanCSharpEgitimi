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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // dateTimePicker2 den bir tarih seçildiğinde burası çalışır
            MessageBox.Show("İki Tarih Arasında " + (dateTimePicker1.Value - dateTimePicker2.Value).Days.ToString() + " gün vardır!");
        }
    }
}
