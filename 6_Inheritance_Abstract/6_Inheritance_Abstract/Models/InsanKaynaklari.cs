using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Inheritance_Abstract.Models
{
    public sealed class InsanKaynaklari : Personel
    {
        //////IK Görevleri //////
        public bool IseAlim { get; set; }
        public bool MaasBelirler { get; set; }
        public bool HizmeticiEgitimPlanlar { get; set; }

        public override void Calis()
        {
            System.Windows.Forms.MessageBox.Show("Personel Arar Bulurum");
        }
    }
}
