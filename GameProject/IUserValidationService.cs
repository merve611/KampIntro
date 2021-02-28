using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService        //Kullanıcı Doğrulama Servisi
    {
        bool Validate(Gamer gamer);         //Validate = doğrulama
       
    }
}
