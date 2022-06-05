using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models;

namespace Wormhunt.Core.Data
{
    public static class WormLibrary
    {
        public static readonly Worm PinkWorm = new Worm()
        {
            Id = 1,
            Name = "Pink Worm",
        };

        public static readonly Worm BrownWorm = new Worm()
        {
            Id = 2,
            Name = "Brown Worm",
        };

        public static readonly Worm ShortWorm = new Worm()
        {
            Id = 3,
            Name = "Short Worm",
        };

        public static readonly Worm LongWorm = new Worm()
        {
            Id = 4,
            Name = "Long Worm",
        };
    }
}
