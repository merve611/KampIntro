using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoggerService        //Interface içinde sadece imza metotları olur, içi dolu olamaz.
    {
        void Log();
    }
}


//Loglama: Kim, Ne zaman hangi operasyonu çağırdı ? Yani o sistem de olan hareketleri döktüğümüz bir dökümdür.
//Loglamayı farklı yöntemlerle uygulayabilirsiniz. Logları bir dosyada tutmak, logları veri tabanında tutmak, logları sms olarak atabiliriz(Örneğin kişi krediye başvurduğunda ona sms gitmesi.)
//Bu yöntemlerin hepsi logluyor hepsinin imzası aynı fakat dosyaya yazarken dosyaya yazma kodları, veritabanına yazarken veri tabanına yazma kodlaro, sms yollarken sms yollama kodları yazılır.Ama hepsinde yapılan işlem bir loglamadır.