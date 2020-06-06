using _13_Generics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Generics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "Ayşe";
            ogr1.Soyadi = "İLHANLI";

            Ogrenci ogr2 = new Ogrenci();
            ogr2.Adi = "İlayda";
            ogr2.Soyadi = "DEMİRCİ";

            Ogrenci ogr3 = new Ogrenci();
            ogr3.Adi = "Selim";
            ogr3.Soyadi = "ÇALIŞKAN";

            Sinif sinif1 = new Sinif();
            sinif1.SinifNo = "502";
            sinif1.Egitmen = "Bilal YILMAZ";
            sinif1.Ogrenciler.Add(ogr1);
            sinif1.Ogrenciler.Add(ogr2);
            sinif1.Ogrenciler.Add(ogr3);

            Ogrenci ogr4 = new Ogrenci();
            ogr4.Adi = "Ayşe";
            ogr4.Soyadi = "İLHANLI";

            Ogrenci ogr5 = new Ogrenci();
            ogr5.Adi = "İlayda";
            ogr5.Soyadi = "DEMİRCİ";

            Ogrenci ogr6 = new Ogrenci();
            ogr6.Adi = "Selim";
            ogr6.Soyadi = "ÇALIŞKAN";

            Sinif sinif2 = new Sinif();
            sinif2.SinifNo = "502";
            sinif2.Egitmen = "Bilal YILMAZ";
            sinif2.Ogrenciler.Add(ogr4);
            sinif2.Ogrenciler.Add(ogr5);
            sinif2.Ogrenciler.Add(ogr6);

            List<Sinif> yoklamalar = new List<Sinif>();

            yoklamalar.Add(sinif1);
            yoklamalar.Add(sinif2);

            Yoklama y = new Yoklama();
            y.sinif = sinif1;
            y.Ekle(ogr1);
            y.Ekle(ogr2);
            y.Ekle(ogr3);

            Dictionary<Sinif, List<Ogrenci>> yoklamaListesi = new Dictionary<Sinif, List<Ogrenci>>();

            yoklamaListesi = y.Listele();
        }
    }
}
