using Momentum.Rabbits.Models;

namespace Momentum.Rabbits.DynamoDb.Rabbits
{
    public static class RabbitConstants
    {
        public const string TABLE_NAME = "RABBITS_TABLE_NAME";
        public const string TABLE_NAME_DEAFULT = "rabbits";

        public const string PARTITION_KEY = "RABBITS_PARTITION_KEY";
        public const string PARTITION_KEY_DEAFULT = nameof(Rabbit.Id);

        public const string RANGE_KEY = "RABBITS_RANGE_KEY";
        public const string RANGE_KEY_DEFAULT = null;

        public const string ALLOW_UPSERT = "RABBITS_ALLOW_UPSERT";
        public const bool ALLOW_UPSERT_DEFAULT = false;
    } // end class
} // end namespace