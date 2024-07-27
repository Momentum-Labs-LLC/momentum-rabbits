using Microsoft.Extensions.Logging;
using Momentum.Rabbits.Models;
using Momentum.Rabbits.Services.Rabbits.Interfaces;
using Momentum.Repositories.Interfaces;

namespace Momentum.Rabbits.Services.Rabbits.Rabbits
{
    public abstract class RabbitService<TPage, TSearchRequest, TSearchResponse, TSearchRepository> :
            IRabbitService<TPage, TSearchRequest, TSearchResponse>
        where TSearchRequest : IRabbitSearchRequest<TPage>
        where TSearchResponse : ISearchResponse<Rabbit, TPage>
        where TSearchRepository : IRabbitSearchRepository<TPage, TSearchRequest, TSearchResponse>
    {
        protected readonly IRabbitRepository _rabbitRepository;
        protected readonly TSearchRepository _rabbitSearchRepository;
        protected readonly ILogger _logger;

        public RabbitService(
            IRabbitRepository rabbitRepository, 
            TSearchRepository rabbitSearchRepository,
            ILogger<RabbitService<TPage, TSearchRequest, TSearchResponse, TSearchRepository>> logger)
        {
            _rabbitRepository = rabbitRepository ?? throw new ArgumentNullException(nameof(rabbitRepository));
            _rabbitSearchRepository = rabbitSearchRepository ?? throw new ArgumentNullException(nameof(rabbitSearchRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        } // end method

        public virtual async Task<Rabbit> CreateAsync(Rabbit rabbit, CancellationToken token = default)
        {
            rabbit.Id = Guid.NewGuid();
            return await _rabbitRepository.CreateAsync(rabbit, token).ConfigureAwait(false);
        } // end method

        public virtual async Task DeleteAsync(Rabbit rabbit, CancellationToken token = default)
        {
            await _rabbitRepository.DeleteAsync(rabbit, token).ConfigureAwait(false);
        } // end method

        public virtual async Task<Rabbit?> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _rabbitRepository.GetAsync(id, token).ConfigureAwait(false);
        } // end method

        public abstract Task<TSearchResponse> GetByUserId(Guid userId, CancellationToken token = default);

        public virtual async Task<Rabbit> UpdateAsync(Rabbit rabbit, CancellationToken token = default)
        {
            return await _rabbitRepository.UpdateAsync(rabbit, token).ConfigureAwait(false);
        } // end method
    } // end class
} // end namespace