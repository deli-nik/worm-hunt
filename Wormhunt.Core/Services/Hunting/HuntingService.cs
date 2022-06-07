using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models;

namespace Wormhunt.Core.Services.Hunting
{
    public class HuntingService : IHuntingService
    {
        private readonly IWormAttractionStrategy _wormAttractionStrategy;

        public HuntingService(IWormAttractionStrategy wormAttractionStrategy)
        {
            _wormAttractionStrategy = wormAttractionStrategy;
        }

        public string Hunt(Hunter hunter)
        {
            var result = _wormAttractionStrategy.Attract(hunter);

            if (!result.IsSuccessful)
            {
                return "You failed to catch a worm. Sorry, noob.";
            }
            else
            {
                return $"You successfully caught {result.CaughtWorm.Name}!";
            }
        }
    }
}
