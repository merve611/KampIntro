using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection - Bu metodun yani BasvuruYap'ın hangi kredi türü olacağını ve hangi loglayıcı olacağını enjekte ediyoruz.
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)      //Birden fazla log yapacak isek list ekleriz. Örenğin aynı ada hem database hem de sms logger yollamak istersek
        {
            //Başvuran bilgilerini değerlendirme
            //
            
           
            krediManager.Hesapla();                         //Hangi loglayıcı seçilmiş ise onu logla.
            foreach (var LoggerService in loggerServices)
            {
                LoggerService.Log();
            };        
        }
        public void KrediOnBilgiledirmesiYap(List<IKrediManager> krediler)      //Birden fazla kredinin ön hesabını yapmak için liste kullandık.
        {
            foreach (var kredi in krediler)         //Listedeki her bir kredinin hesabını yap
            {
                kredi.Hesapla();
            }
        }
    }
}

