using _8_Interface.FutbolModels;
using _8_Interface.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
       INTERFACE
      Inteface bir sınıfa yön veren öğretmen gibidir. Öğretmenin sınıftaki görevi nedir? Öğrencilere ne yapacaklarını söylemektir. İşte interface'de c# dilindeki classların hocaları gibidirler. Interface içerisine kod gövdesi yazılamaz sadece yön verir ve class'a ne yapacaklarını söyler. Bir class birden fazla Interface'i implemente edebilir yani uygulayabilir. ancak class interface'i kendine uyguluyor ise kesinlikle metotlarını  ezmek (override) zorundadır.

       INTERFACE KURALLARI
       1) Interface'ler yapı olarak class'a çok benzediği için genellikle başına 'I' harfi konur ama kural değildir.
       2) Interface'ler içeresine Field - Değişken tanımlanamaz!
       3) Interface'ler içerisinde access modifier kullanılmaz!
       4) Interface'ler içerisinde contructor yazılmaz!
       5) Interface'ler içerisinde yazılan propertylerin içeleri boş bırakılır.
       6) Interface'ler içerisinde kullanılan metotların kod gövdesi belirtilmez! İçerisinde interface'in uygulandığı (implement) classta doldurulur.

       */
        Kaleci kl = new Kaleci()
        {
            AdiSoyadi = "Volkan Demirel",
            Agresiflik = 70,
            FormaNumarasi = "1",
            Refleks = 100,
            MilliMi = true,
            SutGucu = 55
        };
        Defans df = new Defans()
        {
            AdiSoyadi = "Cihat Kır",
            Agresiflik = 100,
            FormaNumarasi = "10",
            MilliMi = false,
            Refleks = 100,
            SutGucu = 60
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            //Mercedes m = new Mercedes("Mercedes","E250 AMG COUPE");
            //m.ToBilgiler();
            listBox1.Items.Add(kl);
            listBox1.Items.Add(df);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.SelectedItem.GetType().GetInterface("IFutbolcu") != null -> Listboxtan seçilen elemanın tipini getir ve bu tipinde interface'ini al, Eğer bu eleman "IFutbolcu" interface'inden türemişse
            if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().GetInterface("IFutbolcu") != null)
            {
                flowLayoutPanel1.Controls.Clear();
                string classAdi = listBox1.SelectedItem.GetType().Name;
                lblBilgi.Text = classAdi;
                IFutbolcu gelen = (IFutbolcu)listBox1.SelectedItem;
                //MessageBox.Show(gelen.AdiSoyadi);
                foreach (PropertyInfo item in gelen.GetType().GetProperties())
                {
                    Label lbl = new Label();
                    lbl.Text = $"{item.Name} : {item.GetValue(gelen, null).ToString()}";
                    lbl.AutoSize = false;
                    lbl.Width = flowLayoutPanel1.Width;
                    flowLayoutPanel1.Controls.Add(lbl);
                }
            }
        }
    }
}
