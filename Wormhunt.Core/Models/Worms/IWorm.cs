using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models.Enums;

namespace Wormhunt.Core.Models.Worms
{
    public interface IWorm
    {
        int Id { get; }

        WormKey Key { get; }

        string Name { get; }

        string ImageUrl { get; }
    }
}
