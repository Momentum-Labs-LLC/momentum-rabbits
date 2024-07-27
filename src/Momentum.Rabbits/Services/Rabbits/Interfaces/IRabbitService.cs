using Momentum.Rabbits.Models;
using Momentum.Repositories.Interfaces;

namespace Momentum.Rabbits.Services.Rabbits.Interfaces
{
    public interface IRabbitService<TPage, TSearchRequest, TSearchResponse>        
        where TSearchRequest : ISearchRequest<TPage>
        where TSearchResponse : ISearchResponse<Rabbit, TPage>
    {
        Task<TSearchResponse> GetByUserId(Guid userId, CancellationToken token = default);
        Task<Rabbit?> GetAsync(Guid id, CancellationToken token = default);
        Task<Rabbit> CreateAsync(Rabbit rabbit, CancellationToken token = default);
        Task<Rabbit> UpdateAsync(Rabbit rabbit, CancellationToken token = default);
        Task DeleteAsync(Rabbit rabbit, CancellationToken token = default);
    } // end interface
} // end namespace