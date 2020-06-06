using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ClassObject.Models
{
    public class Araba
    {
        private string _Marka;

        public string Marka
        {
            get { return _Marka; }
            set { _Marka = value; }
        }

        private string _Model;

        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        private decimal _Motor;

        public decimal Motor
        {
            get { return _Motor; }
            set { _Motor = value; }
        }

        public override string ToString()
        {
            return $"Marka: {this.Marka},\nModel: {this.Model},\nMotor: {this.Motor}";
        }

    }
}
