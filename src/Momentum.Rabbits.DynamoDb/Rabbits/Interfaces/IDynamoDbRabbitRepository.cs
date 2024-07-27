using Momentum.DynamoDb.Repositories.Interfaces;
using Momentum.Rabbits.Models;
using Momentum.Rabbits.Services.Rabbits.Interfaces;

namespace Momentum.Rabbits.DynamoDb.Rabbits.Interfaces
{
    public interface IDynamoDbRabbitRepository : 
            IDynamoDbRepository<Rabbit, IRabbitRepositoryConfiguration>,
            IRabbitRepository
    {
        
    } // end interface
} // end namespace