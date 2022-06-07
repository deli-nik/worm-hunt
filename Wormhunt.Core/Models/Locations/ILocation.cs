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
    public interface ILocation
    {
        int Id { get; }

        LocationKey Key { get; }

        string Name { get; }

        public IList<IWorm> GetPossibleWorms(Hunter hunter);
    }
}
