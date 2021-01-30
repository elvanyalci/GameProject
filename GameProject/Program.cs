using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id = 1,IdentityNumber=15406973162,Ad="Elvan",Soyad="YALÇI",BirtYear=1996 };
            Gamer gamer2 = new Gamer { Id = 2, Ad = "Elif", Soyad = "GÜREL", BirtYear = 1995, IdentityNumber = 15427972434 };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            Console.WriteLine("------------------");
            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(new Campaing { Id=1,Name="Bahar Kampanyası"});
            OrderManager orderManager = new OrderManager(new CampaingManager());
            Campaing campaing2 = new Campaing { Id = 2, Name = "Güz Kampanyası" };
            orderManager.Add(campaing2);

        }
    }
}
