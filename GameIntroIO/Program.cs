using GameIntroIO.Abstract;
using GameIntroIO.Concrete;
using GameIntroIO.Entities;
using System;

namespace GameIntroIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player
            {
                FirstName = "Engin",
                LastName = "Demiroğ",
                Id = 1,
                DateOfBirth = new DateTime(1985, 1, 6),
                TcNo = "4242424242"
            };

            Game game1 = new Game
            {
                Id = 1,
                GameName = "Arma3",
                GamePrice = 145.5
            };

            Campaigning campaign1 = new Campaigning
            {
                CampaigningName = "kasım indirimi",
                Id = 1,
                StartDate = new DateTime(2023, 1, 1),
                EndDate = new DateTime(2023, 1, 30)
            };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Delete(player1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            CampaigningManager campaignManager = new CampaigningManager();
            campaignManager.UpdateCampaign(game1, campaign1);
        }
    }
}
