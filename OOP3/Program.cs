using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Interfaceler de o interfaceyi ımplemante eden o classın referans numarasını tutabiliyor.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {new SmsLoggerService(), fileLoggerService };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager,loggers);       //Hangi kredi türünü seçersek onun hesapla operasyonu çalışır.

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };  //Listedeki her bir krediyi hesapla
          //  basvuruManager.KrediOnBilgiledirmesiYap(krediler);
            



        }
    }
}
