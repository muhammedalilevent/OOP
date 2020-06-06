using _4_ReferanceType_ValueType.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_ReferanceType_ValueType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * .NET Framework mantığı gereği, uygulama üzeinde tutlan tüm nesneler ram üzerinde kendilerine bir yer edinirler. Ram'in teknik yapısına baktığımızda ise bu nesnelerin farklı blokta tutulduğunu görürüz. Bunların bir tanesi 'Stack' diğeri ise 'Heap' bölümüdür.
             * 
             * Stack bölümünde Value Type olarak adlandırdığımız değer tipleri tutulur. (String hariç tüm değişkenler, Enum ve Struct'lar)
             * 
             * Heap bölümünde ise Referance Type olarak adlandırdığımız değer tipleri tutulur.(String,Class,Delegate,Array)
             * 
             * Value Type'ların değerleri kopyalanırken Referance Type'larda değer taşınır.
             * 
             * ***Value Type: Value Tipindeki bir nesne tüm veriyi kendi içerisinde tutar.
             * ***Referance Type: Direk olarak veriyi tutmaz bunun yerine verinin adresini gösteren bir referance tutar.
             */
        }

        private void btnReferance_Click(object sender, EventArgs e)
        {
            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "Erhan";
            ogr1.SoyAdi = "Sipahi";

            Ogrenci ogr2 = new Ogrenci();
            //ogr2 = ogr1;
            ogr2.Adi = ogr1.Adi;
            ogr2.SoyAdi = ogr1.SoyAdi;

            Ogrenci ogr3 = new Ogrenci();
            //ogr3 = ogr2;
            ogr3.Adi = ogr2.Adi;
            ogr3.SoyAdi = ogr2.SoyAdi;

            Ogrenci ogr4 = new Ogrenci();
            //ogr4 = ogr3;
            ogr4.Adi = ogr3.Adi;
            ogr4.SoyAdi = ogr3.SoyAdi;

            Ogrenci ogr5 = new Ogrenci();
            //ogr5 = ogr4;
            ogr5.Adi = ogr4.Adi;
            ogr5.SoyAdi = ogr4.SoyAdi;

            ogr3.Adi = "Burak";

            MessageBox.Show(ogr5.Adi);
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.FirstName = "Murat";
            std.LastName = "Taştemür";

            Student std2 = new Student();
            std2 = std;
            std2.FirstName = "Sezer";

            MessageBox.Show(std.FirstName);
        }
    }
}
