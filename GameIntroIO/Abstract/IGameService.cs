using GameIntroIO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntroIO.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);

    }
}
