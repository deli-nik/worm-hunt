using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models;

namespace Wormhunt.Core.Data
{
    public static class LocationLibrary
    {
        public static readonly Location Backyard = new Location()
        {
            Id = 1,
            Name = "Backyard",
        };
    }
}
