using Momentum.DynamoDb.Repositories.Interfaces;
using Momentum.Rabbits.Models;
using Momentum.Rabbits.Services.Rabbits.Interfaces;

namespace Momentum.Rabbits.DynamoDb.Rabbits.Interfaces
{
    public interface IDynamoDbRabbitService : 
        IRabbitService<DynamoDbPage, IRabbitSearchRequest, IDynamoDbSearchResponse<Rabbit>>
    {
        
    } // end interface
} // end namespace