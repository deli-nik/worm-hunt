using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Data;
using Wormhunt.Core.Models;

namespace Wormhunt.Core
{
    public static class MockDataProvider
    {
        public static Hunter GetHunter()
        {
            return new Hunter()
            {
                Id = 1,
                Name = "Mousy",
                Location = LocationLibrary.Backyard,
                LocationState = LocationStateLibrary.Normal,
                TrapConfiguration = new TrapConfiguration()
                {
                    Trap = TrapLibrary.BigBirdie,
                    TrapBase = TrapBaseLibrary.PlainWood,
                    Bait = BaitLibrary.Plankton
                },
            };
        }

        public static IList<Worm> GetWorms()
        {
            return new List<Worm>()
            {
                WormLibrary.PinkWorm,
                WormLibrary.BrownWorm,
                WormLibrary.ShortWorm,
                WormLibrary.LongWorm,
            };
        }

        public static IList<Location> GetLocations()
        {
            return new List<Location>()
            {
                LocationLibrary.Backyard,
            };
        }
    }
}
