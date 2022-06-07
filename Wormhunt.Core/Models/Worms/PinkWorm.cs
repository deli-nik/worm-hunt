using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models.Enums;

namespace Wormhunt.Core.Models.Worms
{
    public class PinkWorm : IWorm
    {
        public int Id => 1;

        public WormKey Key => WormKey.PinkWorm;

        public string Name => "Pink Worm";

        public string ImageUrl => String.Empty;
    }
}
