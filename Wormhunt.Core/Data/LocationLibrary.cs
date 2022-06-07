using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models;
using Wormhunt.Core.Models.Enums;
using Wormhunt.Core.Models.Locations;

namespace Wormhunt.Core.Data
{
    public static class LocationLibrary
    {
        public static readonly ILocation KingsBackyard = new KingsBackyardLocation();
    }
}
