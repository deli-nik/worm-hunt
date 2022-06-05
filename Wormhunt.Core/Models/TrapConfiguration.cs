using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormhunt.Core.Models
{
    public class TrapConfiguration
    {
        public Trap Trap { get; set; }

        public TrapBase TrapBase { get; set; }

        public Bait Bait { get; set; }

        public int EffectiveTrapPower => Trap?.EffectivePower ?? 0 + TrapBase?.EffectivePower ?? 0;
    }
}
