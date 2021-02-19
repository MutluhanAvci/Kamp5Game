using System;
using Kamp5Game.Abstract;
using Kamp5Game.Concrete;
using Kamp5Game.Entities;

namespace Kamp5Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new IValidationManager());
            Gamer gamer = new Gamer() { FirstName = "Mutluhan", LastName = "Avcı", DateOfBirth =1999, TCno = 123456789 };
            Game game = new Game() { GameId = 1, GameName = "Call of Duty MW2", GamePrice = 120 };
            gamerManager.Add(gamer);

            IValidationManager validationManager = new IValidationManager();
            validationManager.Validate(gamer);

            CampaignManager campaign = new CampaignManager();
            Campaign campaign1 = new Campaign() { CampaignName = "Cpt.Price", DiscountRate = 30, RaiseRate = 15 };
            campaign.Add(campaign1, game);
            campaign.Delete(campaign1, game);
            campaign.Update(campaign1, game);

            SaleManager sale = new SaleManager();
            Sale sale1 = new Sale() { GameName = "Call of Duty MW2", Gamer = "Mutluhan Avcı", Price = 249 };
            sale.Sales(game, gamer, sale1);
            sale.CampaignSales(game, gamer, campaign1, sale1);

        }
    }
}
