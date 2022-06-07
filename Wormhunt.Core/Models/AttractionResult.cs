using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wormhunt.Core.Models.Worms;

namespace Wormhunt.Core.Models
{
    /// <summary>
    /// Result for attract action.
    /// </summary>
    public class AttractionResult
    {
        /// <summary>
        /// Determines if attraction is successful.
        /// </summary>
        public bool IsSuccessful { get; set; }

        /// <summary>
        /// If attraction is successful, returns the worm.
        /// Otherwise, returns null.
        /// </summary>
        public IWorm CaughtWorm { get; set; }
    }
}
