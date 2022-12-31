using GameIntroIO.Abstract;
using GameIntroIO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntroIO.Concrete
{
    class PlayerManager : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine(player.FirstName + "Adlı oyuncunun kaydı silindi!");
        }

        public void Register(Player player)
        {
            Console.WriteLine(player.FirstName + "Adlı oyuncunun kayıt işlemi başarıyla gerçekleşti");

        }

        public void Update(Player player)
        {
            Console.WriteLine(player.FirstName + "Adlı oyuncunun güncelleme işlemi başarıyla gerçekleştri ");
        }
    }
}
