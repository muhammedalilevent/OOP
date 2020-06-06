using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Cunstructor.Models
{
    //Constructor - YAPICI METOTLAR
    //Yapıcı metotlardan kısaca bahsedersek, static olmayan (ileride öğreneceğiz) bir sınıf içerisindeki property'lere (özelliklere) sınıfın intance (örnek kopya alma) esnasında değerler verme işlemidir. Bu metotlar tıpkı void metotlar gibi çalışır ve geriye herhangi tipte (int,string, vs...) değer döndürmezler ancak bu metodun bir adıda olmaz çünkü yapıcı metodlar sınıfın birebir kendi adıyla yazılmak zorundadırlar.
    public class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Motor { get; set; }
        public string Kasa { get; set; }

        public Araba(string marka, string model, decimal motor)
        {
            this.Marka = marka;
            this.Model = model;
            this.Motor = motor;
        }
        public Araba(string marka, string model, decimal motor,string kasa)
        {
            this.Marka = marka;
            this.Model = model;
            this.Motor = motor;
            this.Kasa = kasa;
        }
        public override string ToString()
        {
            string mesaj = "";
            if (this.Kasa != null)
            {
                mesaj =  $"Marka: {this.Marka},\nModel: {this.Model},\nMotor: {this.Motor},\nKasa:{this.Kasa}";
            }
            else
            {
                mesaj = $"Marka: {this.Marka},\nModel: {this.Model},\nMotor: {this.Motor}";
            }
            return mesaj;
            
        }

    }
}
