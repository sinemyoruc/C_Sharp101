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
    public partial class Yeni1 : Form
    {
        public Yeni1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("ANASAYFAYA DÖNÜLÜYOR");
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

    }
}
