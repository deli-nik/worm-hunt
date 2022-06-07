using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models;
using Wormhunt.Core.Models.Enums;

namespace Wormhunt.Core.Data
{
    public static class TrapLibrary
    {
        public static readonly Trap BigBirdie = new Trap()
        {
            Id = 1,
            Name = "Big Birdie",
            Luck = 5,
            Power = 100,
            TrapType = TrapType.Physical
        };
    }
}
