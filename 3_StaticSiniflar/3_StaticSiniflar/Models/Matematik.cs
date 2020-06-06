using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_StaticSiniflar.Models
{
    //STATIC CLASS 
    //Eğer Nesneye bağımlı işlemler gerçekleştiriyorsanız yani amaç sadece belirli bir duruma hizmet eden birden fazla öğeyi birarada toplamak ise ilgili sınıfı Static olarak işaretleyebilirsiniz ve içerisindeki tüm öğelere intance'tan bağımsız olarak erişebilirsiniz.
    public class Matematik
    {
        public static decimal YercekimiKuvveti { get { return 9.8M; } }
        public static double PI { get { return Math.PI; }  }
        //const => Sabit, kendiliğinden statictir.
        public const int KaldirmaKuvveti = 12;
        public static readonly int IndirmeKuvveti = 2;

        public static int Hesapla()
        {
            return 1000;
        }
        public static int Hesapla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
