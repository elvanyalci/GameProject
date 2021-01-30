using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt eklendi");
            }
            else
            {
                Console.WriteLine("Kayıt ekleme başarısız.geçersiz kullanıcı");
            }

            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }
    }
}
