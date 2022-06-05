using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormhunt.Core.Models
{
    public class TrapBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Power { get; set; }

        public int Luck { get; set; }

        public int EffectivePower => Power + Luck;
    }
}
