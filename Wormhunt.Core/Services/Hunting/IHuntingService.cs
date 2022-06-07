using Wormhunt.Core.Models;

namespace Wormhunt.Core.Services.Hunting
{
    public interface IHuntingService
    {
        void Hunt(Hunter hunter);
    }
}