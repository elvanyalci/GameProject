using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        ICampaingService _campaingService;

        public OrderManager(ICampaingService campaingService)
        {
            _campaingService = campaingService;
        }

        public void Add(Campaing campaing)
        {
            Console.WriteLine("satış yapıldı  "+campaing.Name);
        }
    }
}
