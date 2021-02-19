using Kamp5Game.Abstract;
using Kamp5Game.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5Game.Concrete
{
    public class GamerManager : IGamerService
    {
        IValidationService validationService;
        
        public GamerManager(IValidationManager validationManager)
        {
            validationService = validationManager;
        }
        public void Add(Gamer gamer)
        {
            if (validationService.Validate(gamer))

            {
                Console.WriteLine("Başarılı şekilde eklenen oyuncu:"+gamer.FirstName+""+gamer.LastName);
            }
            else
            {
                Console.WriteLine("Başarısız kayıt:"+gamer.FirstName+""+gamer.LastName);
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Başarılı şekilde silinen oyuncu:" + gamer.FirstName + "" + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Başarılı şekilde güncellenen oyuncu:" + gamer.FirstName + "" + gamer.LastName);
        }
    }
}
