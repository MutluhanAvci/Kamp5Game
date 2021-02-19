using System;
using System.Collections.Generic;
using System.Text;
using Kamp5Game.Entities;

namespace Kamp5Game.Abstract
{
    public interface ISaleService
    {
        void Sales(Game game, Gamer gamer,Sale sale);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign,Sale sale);



    }
}
