using System;
using System.Collections.Generic;
using System.Text;
using Kamp5Game.Abstract;
using Kamp5Game.Entities;

namespace Kamp5Game.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign, Game game)
        {
            Console.WriteLine(game.GameName+""+"için yeni kampanya eklendi!!!"+"Yüzde"+""+campaign.DiscountRate+""+"indirimde!!!");
        }

        public void Delete(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Campaign campaign, Game game)
        {
            Console.WriteLine("Kampanya güncellendi!");
        }
    }
}
