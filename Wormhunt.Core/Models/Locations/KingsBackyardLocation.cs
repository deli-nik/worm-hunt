using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Data;
using Wormhunt.Core.Models.Enums;
using Wormhunt.Core.Models.Worms;

namespace Wormhunt.Core.Models.Locations
{
    public class KingsBackyardLocation : ILocation
    {
        public int Id => 1;

        public LocationKey Key => LocationKey.KingsBackyard;

        public string Name => "King's Backyard";

        public IList<IWorm> GetPossibleWorms(Hunter hunter)
        {
            return new List<IWorm>()
            {
                WormLibrary.PinkWorm,
                WormLibrary.BrownWorm,
                WormLibrary.ShortWorm,
                WormLibrary.LongWorm,
            };
        }
    }
}
