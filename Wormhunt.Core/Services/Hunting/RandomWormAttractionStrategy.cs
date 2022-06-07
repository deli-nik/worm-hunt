using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models;

namespace Wormhunt.Core.Services.Hunting
{
    public class RandomWormAttractionStrategy : IWormAttractionStrategy
    {
        public AttractionResult Attract(Hunter hunter)
        {
            return new AttractionResult() { IsSuccessful = false };
        }
    }
}
