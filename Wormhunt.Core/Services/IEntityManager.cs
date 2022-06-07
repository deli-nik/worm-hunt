using Wormhunt.Core.Models.Enums;
using Wormhunt.Core.Models.Locations;
using Wormhunt.Core.Models.Worms;

namespace Wormhunt.Core.Services
{
    public interface IEntityManager
    {
        ILocation GetLocation(LocationKey key);

        IWorm GetWorm(WormKey key);
    }
}