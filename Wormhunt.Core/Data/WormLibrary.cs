using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models.Enums;
using Wormhunt.Core.Models.Worms;

namespace Wormhunt.Core.Data
{
    public static class WormLibrary
    {
        public static readonly IWorm PinkWorm = new PinkWorm();
        public static readonly IWorm BrownWorm = new BrownWorm();
        public static readonly IWorm ShortWorm = new ShortWorm();
        public static readonly IWorm LongWorm = new LongWorm();
    }
}
