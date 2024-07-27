using Microsoft.Extensions.Logging;
using Momentum.DynamoDb;
using Momentum.DynamoDb.Client.Interfaces;
using Momentum.DynamoDb.Repositories;
using Momentum.Rabbits.DynamoDb.Rabbits.Interfaces;
using Momentum.Rabbits.Models;

namespace Momentum.Rabbits.DynamoDb.Rabbits
{
    public class RabbitRepository :
        DynamoDbRepositoryBase<Rabbit, IRabbitRepositoryConfiguration>,
        IDynamoDbRabbitRepository
    {
        public RabbitRepository(
                IDynamoDBClientFactory clientFactory, 
                IRabbitRepositoryConfiguration configuration, 
                ILogger<RabbitRepository> logger) 
            : base(clientFactory, configuration, logger)
        {
        } // end method

        protected override async Task<DynamoDbDocument> BuildDocumentAsync(Rabbit item, CancellationToken token = default)
        {
            return new DynamoDbDocument()
                .AddField(nameof(Rabbit.Id), item.Id)
                .AddField(nameof(Rabbit.Name), item.Name)
                .AddField(nameof(Rabbit.BirthTimestamp), item.BirthTimestamp)
                .AddField(nameof(Rabbit.LitterId), item.LitterId)
                .AddField(nameof(Rabbit.PaternalId), item.PaternalId)
                .AddField(nameof(Rabbit.MaternalId), item.MaternalId)
                .AddField(nameof(Rabbit.UserId), item.UserId)
                .AddField(nameof(Rabbit.LastUpdatedOn), item.LastUpdatedOn)
                .AddField(nameof(Rabbit.LastUpdatedBy), item.LastUpdatedBy);
        } // end method

        protected override async Task<DynamoDbDocument> BuildKeyAsync(Guid id, CancellationToken token = default)
        {
            return new DynamoDbDocument().AddField(nameof(Rabbit.Id), id);
        } // end method

        protected override async Task<DynamoDbDocument> BuildKeyAsync(Rabbit item, CancellationToken token = default)
        {
            return await BuildKeyAsync(item.Id, token).ConfigureAwait(false);
        } // end method

        protected override async Task<Rabbit> ReadDocumentAysnc(DynamoDbPage document, CancellationToken token = default)
        {
            Rabbit result = null;

            if(document != null && document.Any())
            {
                result = new Rabbit()
                {
                    Id = document.ReadGuid(nameof(Rabbit.Id), true).Value,
                    Name = document.ReadString(nameof(Rabbit.Name)),
                    BirthTimestamp = document.ReadDateTime(nameof(Rabbit.BirthTimestamp), true).Value,
                    LitterId = document.ReadGuid(nameof(Rabbit.LitterId)),
                    PaternalId = document.ReadGuid(nameof(Rabbit.PaternalId)),
                    MaternalId = document.ReadGuid(nameof(Rabbit.MaternalId)),
                    UserId = document.ReadGuid(nameof(Rabbit.UserId), true).Value,
                    LastUpdatedOn = document.ReadDateTime(nameof(Rabbit.LastUpdatedOn), true).Value,
                    LastUpdatedBy = document.ReadGuid(nameof(Rabbit.LastUpdatedBy))
                };
            } // end if            

            return result;
        } // end method
    } // end class
} // end namespace