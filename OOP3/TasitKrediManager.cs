using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager    //Inheritance ettiğim için KrediManager'daki operasyonlara TasitKrediManager de sahip.
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi ödeme planı hesaplandı. ");
        }
    }
}
