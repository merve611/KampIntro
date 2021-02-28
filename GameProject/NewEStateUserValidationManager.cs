using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewEStateUserValidationManager : IUserValidationService       //Bu dosyada diyelimki devlet yeni bir doğrulama sistemi isterse diye oluşturuldu.
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
