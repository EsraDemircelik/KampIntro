using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject
{
    class OrderManager : IOrderService
    {

        public void Order(Gamer gamer, Campaign campaign,Game game)
        {
           
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli oyuncu " + game.Name +
                "oyunu " + campaign.CampaignName + " kampanyasını kullanarak " + (game.Price - campaign.Discount)  +
                " TL ye satın almıştır");
           


        }

    }
}
