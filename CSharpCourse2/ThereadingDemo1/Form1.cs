using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThereadingDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem1 çalıştı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem2 çalıştı");
        }
    }
}
//Thread = Çekirdek sayısına göre oluşuyor.
//multiTherading = Birden fazla thread oluşuyor ama iki işlem biri bitince diğeri çalışıyor şeklinde oluyor.
//Asenkron programlama = Birden fazla thread açılabilir ama tek thread de iki işlem aynı anda yapılabiliyor.