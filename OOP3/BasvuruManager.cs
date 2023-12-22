using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method 
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //

            krediManager.Hesapla();

            //Hangi loglayıcı seçilmişse onu logla
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) 
        {
            //kredileri dolaş her bir kredinin hesabını yap
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
