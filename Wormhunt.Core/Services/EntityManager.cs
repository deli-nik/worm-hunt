using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models.Enums;
using Wormhunt.Core.Models.Locations;
using Wormhunt.Core.Models.Worms;

namespace Wormhunt.Core.Services
{
    public class EntityManager : IEntityManager
    {
        public IWorm GetWorm(WormKey key)
        {
            return MockDataProvider.GetAllWorms().First(w => w.Key == key);
        }

        public ILocation GetLocation(LocationKey key)
        {
            return MockDataProvider.GetAllLocations().First(l => l.Key == key);
        }
    }
}
