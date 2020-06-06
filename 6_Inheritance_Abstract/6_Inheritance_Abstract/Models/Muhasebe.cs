using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Inheritance_Abstract.Models
{
    public sealed class Muhasebe : Personel
    {
        /////Muhasebe Gorevleri //////
        public bool MaasOdeyebilir { get; set; }
        public bool FaturaKesebilir { get; set; }
        public bool TahsilatYapabilir { get; set; }
        public bool OdemeYapabilir { get; set; }

        public override void Calis()
        {
            System.Windows.Forms.MessageBox.Show("Muhasebe Yaparım");
        }
    }
}
