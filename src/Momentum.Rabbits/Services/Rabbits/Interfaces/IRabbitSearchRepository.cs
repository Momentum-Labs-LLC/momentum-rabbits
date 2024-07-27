using Momentum.Rabbits.Models;
using Momentum.Repositories.Interfaces;

namespace Momentum.Rabbits.Services.Rabbits.Interfaces
{
    public interface IRabbitSearchRepository<TPage, TSearchRequest, TSearchResponse> : 
            ISearchRepository<Rabbit, TPage, TSearchRequest, TSearchResponse>
        where TSearchRequest : IRabbitSearchRequest<TPage>
        where TSearchResponse : ISearchResponse<Rabbit, TPage>
    {
        
    } // end interface
} // end namespace