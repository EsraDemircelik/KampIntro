using System;

namespace GamerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game { Id = 1, Name = "The Sims", Price = 250 };

            Campaign campaign = new Campaign();

            campaign.Id = 1;
            campaign.CampaignName = "Hafta sonu indirimi";
            campaign.Discount = 50;
 
            Gamer gamer = new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);
            gamerManager.Delete(gamer);
            gamerManager.Update(gamer);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            OrderManager orderManager = new OrderManager();
            orderManager.Order(gamer,campaign,game);


        }
    }
}
