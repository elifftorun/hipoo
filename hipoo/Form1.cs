using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hipoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=Convert.ToInt32(textBox1.Text);
            int sayi2=Convert.ToInt32(textBox2.Text);
            double sonuc1 = Math.Sqrt(sayi1 * sayi1 + sayi2 * sayi2);
            int sayi =Convert.ToInt32 (sonuc1);
            double sonuc2 = Math.Round(Math.Sqrt(sayi1*sayi1+sayi2*sayi2),2);
            label1.Text = sonuc2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          int sayi=Convert.ToInt32(textBox3.Text);
            if (sayi < 0)
            {
                sayi = sayi * -1;
            }
            MessageBox.Show("Sayı: " + sayi);
        }
    }
}
