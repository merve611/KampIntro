using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;       //Constructor oluşturduk

        public GamerManager(IUserValidationService userValidationService)       //Ampuldeki Generate constructordan oluştu. Gamer Managerın  içerisinde ben bir doğrulama servisini kullanacağım demek bu. Bu doğrulama servisi fake bi yapı simule etmek için 
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                 Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt Başarısız.");
            }
           
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
