using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Inheritance_Abstract.Models
{
    public sealed class Pazarlama : Personel
    {
        ///////Pazarlama Gorevleri //////
        public bool SatisYapabilir { get; set; }
        public bool SiparisAlir { get; set; }
        public bool MusteriZiyareti { get; set; }
        public bool Kampanya { get; set; }

        public override void Calis()
        {
            System.Windows.Forms.MessageBox.Show("Acayip Satarım...");
        }
    }
}
