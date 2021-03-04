using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "Seden",
                LastName = "Çakmak",
                IdentitiyNumber  = 123450,
                

            }) ;
 

            Console.WriteLine("Hello World!");
        }
    }
}
