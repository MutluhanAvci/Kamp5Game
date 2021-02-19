using System;
using System.Collections.Generic;
using System.Text;
using Kamp5Game.Abstract;
using Kamp5Game.Entities;

namespace Kamp5Game.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi!!!");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi!!!");
        }

        public void UpDate(Game game)
        {
            Console.WriteLine("Oyun güncellendi!!!");
        }
    }
}
