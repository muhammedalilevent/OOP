using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Enums.Models
{
    public class ResultMessage
    {
        public static string message { get; set; }

        public static string GetMessage(Messagetype messageType, string customMessage)
        {
            switch (messageType)
            {
                case Messagetype.Saved:
                    message = "Yeni "+ customMessage + " Kayıt İşlemi Başarılı!...";
                    break;
                case Messagetype.Updated:
                    message = "Güncelleme İşlemi Başarılı!..." + customMessage;
                    break;
                case Messagetype.Deleted:
                    message = "Silme İşlemi Başarılı!..." + customMessage;
                    break;
                case Messagetype.Found:
                    message = "Bulma İşlemi Başarılı!..." + customMessage;
                    break;
                case Messagetype.NotSaved:
                    message = "Yeni Kayıt İşlemi Başarısız!..." + customMessage;
                    break;
                case Messagetype.NotUpdated:
                    message = "Güncelleme İşlemi Başarısız!..." + customMessage;
                    break;
                case Messagetype.NotDeleted:
                    message = "Silme İşlemi Başarısız!..." + customMessage;
                    break;
                case Messagetype.NotFound:
                    message = "Bulma İşlemi Başarısız!..." + customMessage;
                    break;
                case Messagetype.Validation:
                    message = "Kontrol İşlemi Başarısız!..." + customMessage;
                    break;
                case Messagetype.Exception:
                    message = "HATA!..." + customMessage;
                    break;
            }
            return message;
        }
    }
}
