using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models;

namespace Wormhunt.Core.Data
{
    public static class LocationStateLibrary
    {
        public static readonly LocationState Normal = new LocationState()
        {
            Id = 1,
            Name = "Normal",
        };
    }
}
