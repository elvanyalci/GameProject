using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Kampanya eklendi  -->"+campaing.Name);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Kmapanya silindi");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
