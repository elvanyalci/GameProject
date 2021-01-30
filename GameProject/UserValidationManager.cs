using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Ad == "Elvan" && gamer.Soyad == "YALÇI" && gamer.BirtYear == 1996 && gamer.IdentityNumber == 15406973162)
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
