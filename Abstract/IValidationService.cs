using System;
using System.Collections.Generic;
using System.Text;
using Kamp5Game.Entities;

namespace Kamp5Game.Abstract
{
    public interface IValidationService
    {
        bool Validate(Gamer gamer);

    }
}
