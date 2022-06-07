using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models.Enums;

namespace Wormhunt.Core.Models.Worms
{
    public class ShortWorm : IWorm
    {
        public int Id => 3;

        public WormKey Key => WormKey.ShortWorm;

        public string Name => "Short Worm";

        public string ImageUrl => String.Empty;
    }
}
