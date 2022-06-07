using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models.Enums;

namespace Wormhunt.Core.Models.Worms
{
    public class LongWorm : IWorm
    {
        public int Id => 4;

        public WormKey Key => WormKey.LongWorm;

        public string Name => "Long Worm";

        public string ImageUrl => String.Empty;
    }
}
