using System;
using System.Collections.Generic;
using System.Text;
using Kamp5Game.Abstract;
using Kamp5Game.Entities;

namespace Kamp5Game.Concrete
{
    public class SaleManager : ISaleService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign, Sale sale)
        {
            Console.WriteLine(gamer.FirstName+""+"Oyuncusu için"+""+game.GameName+""+"oyununun "+"yüzde "+campaign.DiscountRate+"indirimli fiyatı: "+(sale.Price*(campaign.DiscountRate/100)));
        }

        public void Sales(Game game, Gamer gamer, Sale sale)
        {
            Console.WriteLine(game.GameName+" oyununun"+gamer.FirstName+" oyuncusu için fiyatı: "+sale.Price);
        }
    }
}
