using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Inheritance_Abstract.Models
{
    public sealed class TeknikServis : Personel
    {
        //////Teknik Servis Görevleri ///////
        public bool UrunTeslimAlir { get; set; }
        public bool UrunTeslimEder { get; set; }
        public bool TamirYapabilir { get; set; }
        public bool BakimYapabilir { get; set; }

        public override void Calis()
        {
            System.Windows.Forms.MessageBox.Show("Çok Fena Tamir ederim");
        }
    }
}
