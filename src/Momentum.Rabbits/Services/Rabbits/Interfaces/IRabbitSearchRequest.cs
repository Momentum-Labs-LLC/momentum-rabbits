using Momentum.Repositories.Interfaces;

namespace Momentum.Rabbits.Services.Rabbits.Interfaces
{
    public interface IRabbitSearchRequest<TPage> : ISearchRequest<TPage>
    {
        Guid? UserId { get; }
        
    } // end interface
} // end namespace