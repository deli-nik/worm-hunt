using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Data;
using Wormhunt.Core.Models;
using Wormhunt.Core.Models.Enums;
using Wormhunt.Core.Models.Locations;
using Wormhunt.Core.Models.Worms;

namespace Wormhunt.Core.Services
{
    public static class MockDataProvider
    {
        public static Hunter GetHunter()
        {
            // Hardcoded hunter data.
            return new Hunter()
            {
                Id = 1,
                Name = "Mousy",
                Location = LocationLibrary.KingsBackyard,
                LocationState = LocationStateLibrary.Normal,
                TrapConfiguration = new TrapConfiguration()
                {
                    Trap = TrapLibrary.BigBirdie,
                    TrapBase = TrapBaseLibrary.PlainWood,
                    Bait = BaitLibrary.Plankton
                },
            };
        }

        public static IList<IWorm> GetAllWorms()
        {
            return new List<IWorm>()
            {
                WormLibrary.PinkWorm,
                WormLibrary.BrownWorm,
                WormLibrary.ShortWorm,
                WormLibrary.LongWorm,
            };
        }

        public static IList<ILocation> GetAllLocations()
        {
            return new List<ILocation>()
            {
                LocationLibrary.KingsBackyard,
            };
        }
    }
}
