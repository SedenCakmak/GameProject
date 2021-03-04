using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "Seden" && gamer.LastName == "Çakmak" &&gamer.IdentitiyNumber == 123450) 
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}
