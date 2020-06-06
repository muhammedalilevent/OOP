using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _12_Extension_Metot.Models
{
    public static class ExtensionMethods
    {
        public static DateTime Tomorrow(this DateTime dte)
        {
            return Convert.ToDateTime(dte).AddDays(1);
        }

        public static string ToS(this object str)
        {
            return Convert.ToString(str);
        }
        public static int ToInt(this object num)
        {
            return Convert.ToInt32(num);
        }
        public static string ToMD5(this string param)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(param));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2").ToLower());
            }
            return builder.ToString();
        }
        public static decimal ToMoney(this object param)
        {
            //          N:                     1,054.32 
            //          N0:                    1,054 
            //          N1:                    1,054.3 
            //          N2:                    1,054.32 
            //          N3:                    1,054.322 
            try
            {
                return Convert.ToDecimal(Convert.ToDecimal(param).ToString("F", CultureInfo.CreateSpecificCulture("tr-TR")));
            }
            catch (Exception)
            {
                return 0.00M;
            }
        }
    }
}
