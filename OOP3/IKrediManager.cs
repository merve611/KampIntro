using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{                                       //Okunurluğu artırmak için biz ınterface'leri I harfi ile başlatırız.Interface - Arayüz - Şablon
                                       //Interfaceleri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız. Bu yaptığımız örnekte Hesapla() operasyonu ortaktır fakat kredinin türlerine göre kodu, kuralları da değişmektedir. 
    interface IKrediManager          //İmzanın aynı olduğu ama içerisinin farklı olduğu durumlarda base de oluşturduğumuz class'ı class olarak değilde Interface olarak oluştururuz.
    {                               //Eğerki birisi bu ınterface'i kullanırsa o arkadaşım aşağıdaki metotları kullanmak zorundadır.
        void Hesapla();
        void BiseyYap();           //Bu oluşturduğumuz interface de, o interfacenin içindeki operasyonlar alternatif sistemler için bir şablon ve bu buna ek olarak referans tutucu görevi yapar.

        

    }
}





