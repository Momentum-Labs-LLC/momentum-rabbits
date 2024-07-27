using Momentum.DynamoDb.Repositories.Interfaces;
using Momentum.Rabbits.Services.Rabbits.Interfaces;

namespace Momentum.Rabbits.DynamoDb.Rabbits.Interfaces
{
    public interface IRabbitSearchRequest : 
        IDynamoDbSearchRequest,
        IRabbitSearchRequest<DynamoDbPage> 
    { } // end interface
} // end namespace