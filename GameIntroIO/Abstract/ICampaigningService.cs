using GameIntroIO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntroIO.Abstract
{
    public interface ICampaigningService
    {
        void AddNewCampaign(Game game, Campaigning campaign);
        void DeleteCampaign(Game game, Campaigning campaign);
        void UpdateCampaign(Game game, Campaigning campaign);
    }
}
