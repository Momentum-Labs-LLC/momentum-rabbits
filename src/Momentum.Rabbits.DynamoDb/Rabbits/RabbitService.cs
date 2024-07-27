using Microsoft.Extensions.Logging;
using Momentum.DynamoDb.Repositories.Interfaces;
using Momentum.Rabbits.DynamoDb.Rabbits.Interfaces;
using Momentum.Rabbits.Models;
using Momentum.Rabbits.Services.Rabbits.Rabbits;

namespace Momentum.Rabbits.DynamoDb.Rabbits
{
    public class RabbitService :
            RabbitService<DynamoDbPage, IRabbitSearchRequest, IDynamoDbSearchResponse<Rabbit>, IDynamoDbRabbitSearchRepository>,
            IDynamoDbRabbitService
    {
        public RabbitService(
                IDynamoDbRabbitRepository rabbitRepository, 
                IDynamoDbRabbitSearchRepository rabbitSearchRepository, 
                ILogger<RabbitService> logger) 
            : base(rabbitRepository, rabbitSearchRepository, logger)
        {
        } // end method

        public override Task<IDynamoDbSearchResponse<Rabbit>> GetByUserId(Guid userId, CancellationToken token = default)
        {
            throw new NotImplementedException();
        } // end method
    } // end class
} // end namespace