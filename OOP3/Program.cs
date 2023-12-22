using OOP3;

internal class Program
{
    private static void Main(string[] args)
    {
        IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
        IKrediManager tasitKrediManager = new TasitKrediManager();
        IKrediManager konutKrediManager = new KonutKrediManager();
        IKrediManager esnafKrediManager = new EsnafKredisiManager();


        ILoggerService databaseLoggerService = new DataBaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();


        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(esnafKrediManager, new SmsLoggerService()) ;

        //Bütün krediler listenin içine attım
        //List<IKrediManager> krediler = new List<IKrediManager>() {ıhtiyacKrediManager, tasitKrediManager, konutKrediManager }; 
        
        //basvuruManager.KrediOnBilgilendirmesiYap(krediler);





    }
}