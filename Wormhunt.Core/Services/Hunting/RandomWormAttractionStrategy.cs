using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models;
using Wormhunt.Core.Models.Worms;

namespace Wormhunt.Core.Services.Hunting
{
    public class RandomWormAttractionStrategy : IWormAttractionStrategy
    {
        public AttractionResult Attract(Hunter hunter)
        {
            var attractionRate = 80;
            var isSuccessful = new Random().Next(100) < attractionRate;
            IWorm caughtWorm = null;

            if (isSuccessful)
            {
                var possibleWorms = hunter.Location.GetPossibleWorms(hunter);
                var randomIndex = new Random().Next(possibleWorms.Count);
                caughtWorm = possibleWorms[randomIndex];
            }

            return new AttractionResult() 
            { 
                IsSuccessful = isSuccessful,
                CaughtWorm = caughtWorm,
            };
        }
    }
}
