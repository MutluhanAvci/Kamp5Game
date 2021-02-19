using System;
using System.Collections.Generic;
using System.Text;
using Kamp5Game.Abstract;
using Kamp5Game.Entities;

namespace Kamp5Game.Concrete
{
    public class IValidationManager : IValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName=="Mutluhan"&&gamer.LastName=="Avcı")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
