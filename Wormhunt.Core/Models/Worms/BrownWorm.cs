using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models.Enums;

namespace Wormhunt.Core.Models.Worms
{
    public class BrownWorm : IWorm
    {
        public int Id => 2;

        public WormKey Key => WormKey.BrownWorm;

        public string Name => "Brown Worm";

        public string ImageUrl => String.Empty;
    }
}
