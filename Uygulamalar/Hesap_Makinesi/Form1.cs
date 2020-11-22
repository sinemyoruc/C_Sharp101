using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("BLUEAKADEMİE KURSİYERLERİ HOŞGELDİNİZ!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 + sayi2;
            textBox3.Text = Convert.ToString(toplam);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("GÖRÜŞMEK ÜZERE");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 - sayi2;
            textBox3.Text = Convert.ToString(toplam);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 * sayi2;
            textBox3.Text = Convert.ToString(toplam);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam;
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            toplam = sayi1 / sayi2;
            textBox3.Text = Convert.ToString(toplam);
        }
    }
}
