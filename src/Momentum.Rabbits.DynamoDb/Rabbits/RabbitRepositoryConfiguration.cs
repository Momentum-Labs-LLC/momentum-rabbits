using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.Extensions.Configuration;
using Momentum.Rabbits.DynamoDb.Rabbits.Interfaces;
using Momentum.Rabbits.Models;

namespace Momentum.Rabbits.DynamoDb.Rabbits
{
    public class RabbitRepositoryConfiguration : IRabbitRepositoryConfiguration
    {
        public string TableName { get; protected set; }

        public string PartitionKey { get; protected set; }

        public string? RangeKey { get; protected set; }

        public bool AllowUpsert { get; protected set; }

        public RabbitRepositoryConfiguration(IConfiguration configuration)
        {
            TableName = configuration.GetValue<string>(RabbitConstants.TABLE_NAME, RabbitConstants.TABLE_NAME_DEAFULT);
            PartitionKey = nameof(Rabbit.Id);
            AllowUpsert = false;
        } // end method
    } // end class
} // end namespace