using System;
using System.Collections.Generic;
using System.Text;
using Kamp5Game.Entities;

namespace Kamp5Game.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
