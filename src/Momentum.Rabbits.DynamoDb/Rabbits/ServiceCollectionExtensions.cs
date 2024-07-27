using Microsoft.Extensions.DependencyInjection;
using Momentum.DynamoDb;
using Momentum.Rabbits.DynamoDb.Rabbits.Interfaces;

namespace Momentum.Rabbits.DynamoDb.Rabbits
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRabbitService(this IServiceCollection services)
        {
            return services
                .AddDynamoDbClientFactory()
                .AddSingleton<IRabbitRepositoryConfiguration, RabbitRepositoryConfiguration>()
                .AddTransient<IDynamoDbRabbitRepository, RabbitRepository>()
                .AddTransient<IDynamoDbRabbitSearchRepository, DynamoDbRabbitSearchRepository>()
                .AddTransient<IDynamoDbRabbitService, RabbitService>();
        } // end method
    } // end class
} // end namespace