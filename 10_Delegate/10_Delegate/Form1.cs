using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Delegate
{
    public delegate decimal Hesapla(int adet);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public decimal FiyatHesapla(int miktar)
        {
            return miktar * 10.5M;
        }
        public decimal KDVLiFiyatHesapla(int miktar)
        {
            decimal tutar = miktar * 10.5M;
            return tutar * 1.18M;
        }
        public decimal SonucHesapla(int miktar, Hesapla hes)
        {
            return hes(miktar);
        }
        private void btnDelegate_Click(object sender, EventArgs e)
        {
            //Hesapla hes = FiyatHesapla;
            //MessageBox.Show($"Kdv Hariç 5 adet Ürün Tutarı: {hes(5)}");

            //hes = KDVLiFiyatHesapla;
            //MessageBox.Show($"Kdv Dahil 5 adet Ürün Tutarı: {hes(5)}");

            MessageBox.Show($"Kdv Hariç 5 adet Ürün Tutarı: {SonucHesapla(5,FiyatHesapla)}");
            MessageBox.Show($"Kdv Dahil 5 adet Ürün Tutarı: {SonucHesapla(5,KDVLiFiyatHesapla)}");
        }
    }
}
