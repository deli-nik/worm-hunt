using Wormhunt.Core.Models;

namespace Wormhunt.Core.Services.Hunting
{
    public interface IHuntingService
    {
        string Hunt(Hunter hunter);
    }
}