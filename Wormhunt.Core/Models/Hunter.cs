using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models.Enums;
using Wormhunt.Core.Models.Locations;

namespace Wormhunt.Core.Models
{
    public class Hunter
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TrapConfiguration TrapConfiguration { get; set; }

        public ILocation Location { get; set; }

        public LocationState LocationState { get; set; }
    }
}
