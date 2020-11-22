using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int kontrol = 0;
            sayi = Convert.ToInt32(textBox1.Text);

            if (sayi < 0)
            {
                textBox2.Text = "GEÇERSİZ BİR DEĞER GİRDİNİZ!!!";
            }

            else { 

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0 && sayi / 1 == sayi)
                {
                    kontrol++;
                }
            }

            if (kontrol != 0 || sayi < 2)
            {
                textBox2.Text = "SAYI ASAL DEĞİLDİR";
            }
            else
            {
                textBox2.Text = "SAYI ASALDIR";
            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi, faktoriyel = 1;
            sayi = Convert.ToDouble(textBox1.Text); 
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            if (sayi < 0)
            {
                textBox2.Text = "GEÇERSİZ BİR DEĞER GİRDİNİZ!!!";
            }
            else
            {
                textBox2.Text = faktoriyel.ToString();
            }
        }
    }
}

                    //SİNEM YORUÇ
