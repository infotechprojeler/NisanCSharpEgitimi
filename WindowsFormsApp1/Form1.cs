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
    }
}
