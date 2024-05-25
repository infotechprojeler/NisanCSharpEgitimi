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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int sayi = int.Parse(textBox1.Text);
                progressBar1.Maximum = sayi;
                for (int i = 0; i < sayi; i++)
                {
                    progressBar1.Value = i;
                }
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
