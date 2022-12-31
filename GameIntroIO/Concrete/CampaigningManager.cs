using GameIntroIO.Abstract;
using GameIntroIO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntroIO.Concrete
{
    class CampaigningManager : ICampaigningService
    {
        public void AddNewCampaign(Game game, Campaigning campaign)
        {
            Console.WriteLine(game.GameName + "Adlı oyuna " +campaign.DiscountRate + " oranında kampanya eklendi");
        }

        public void DeleteCampaign(Game game, Campaigning campaign)
        {
            Console.WriteLine(game.GameName + "Adlı oyunun " + campaign.CampaigningName+ " kampanyası silindi!");
        }

        public void UpdateCampaign(Game game, Campaigning campaign)
        {
            Console.WriteLine(game.GameName + "Adlı oyuna " + campaign.DiscountRate + "  kampanyası güncellendi ");
        }
    }
}
