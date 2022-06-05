using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models;

namespace Wormhunt.Core.Data
{
    public static class TrapBaseLibrary
    {
        public static readonly TrapBase PlainWood = new TrapBase()
        {
            Id = 1,
            Name = "Plain Wood",
            Luck = 0,
            Power = 10,
        };
    }
}
