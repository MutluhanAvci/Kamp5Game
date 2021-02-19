using System;
using System.Collections.Generic;
using System.Text;
using Kamp5Game.Entities;

namespace Kamp5Game.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void UpDate(Game game);
        void Delete(Game game);

    }
}
