using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());          //GamerManagera doğrulama sınıfının kim olduğunu söyledik.
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROG",
                IdentityNumber = 12345
            });

        }
    }
}
