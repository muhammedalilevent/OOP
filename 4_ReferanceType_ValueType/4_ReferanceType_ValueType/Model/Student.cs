using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ReferanceType_ValueType.Model
{
    /*
         * STRUCT(YAPI) => En Basit tanımıyla Class'ların değer tipli (ValueType) versiyonlarıdır.
         * Class ile arasındaki fark: Struc'lar başka bir struct'tan yada class'tan miras (kalıtım) almazlar, ancak interface implemente edilebilir.
         * Bir struct doğası gereği 16kb'tan fazla veri alamaz, 16kb'tan büyük yapılar için Class küçük yapılar için Struct kullanılır.
         */
    public struct Student
    {
        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _LastName;

        public string LastName
        {
            get{return _LastName;}
            set{ _LastName = value;}
        }
    }
}
