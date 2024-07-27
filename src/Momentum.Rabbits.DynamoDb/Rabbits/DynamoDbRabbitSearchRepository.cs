using Microsoft.Extensions.Logging;
using Momentum.DynamoDb.Client.Interfaces;
using Momentum.DynamoDb.Repositories;
using Momentum.DynamoDb.Repositories.Interfaces;
using Momentum.Rabbits.DynamoDb.Rabbits.Interfaces;
using Momentum.Rabbits.Models;

namespace Momentum.Rabbits.DynamoDb.Rabbits
{
    public class DynamoDbRabbitSearchRepository :
        DynamoDbSearchRepositoryBase<Rabbit, IRabbitSearchRequest, IDynamoDbSearchResponse<Rabbit>, IRabbitRepositoryConfiguration>,
        IDynamoDbRabbitSearchRepository
    {
        public DynamoDbRabbitSearchRepository(
                IDynamoDBClientFactory clientFactory, 
                IRabbitRepositoryConfiguration configuration, 
                ILogger<DynamoDbRabbitSearchRepository> logger) 
            : base(clientFactory, configuration, logger)
        {
        } // end method

        public override Task<IDynamoDbSearchResponse<Rabbit>> SearchAsync(IRabbitSearchRequest request, CancellationToken token = default)
        {
            throw new NotImplementedException();
        } // end method
    } // end class
} // end namespace