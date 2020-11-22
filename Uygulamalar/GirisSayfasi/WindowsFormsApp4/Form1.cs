using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "aa" && textBox2.Text == "bb")
            {
                MessageBox.Show("YETKİLİ KULLANICI");
                this.Hide();
                Yeni1 y1 = new Yeni1();
                y1.ShowDialog();

            }
            else
            {
                MessageBox.Show("YETKİ YOK");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
