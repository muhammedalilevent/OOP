using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Inheritance_Abstract.Models
{
    public abstract class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yasi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyet Cinsiyeti { get; set; }
        public Egitim Egitim { get; set; }
        public decimal Maas { get; set; }
        public bool AktifMi { get; set; }
        public int TCNO { get; set; }
        public abstract void Calis();

    }
}
