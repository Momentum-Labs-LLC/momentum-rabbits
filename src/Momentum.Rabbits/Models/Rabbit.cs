using Momentum.Genetics.Heredity.Models;
using Momentum.Rabbits.Models.Abstractions;
using NodaTime;

namespace Momentum.Rabbits.Models
{
    public class Rabbit : UserOwnedIndividual
    {
        /// <summary>
        /// Gets or sets the name or tattoo.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the birth timestamp.
        /// </summary>
        public Instant BirthTimestamp { get; set; }

        /// <summary>
        /// Gets or sets the litter identifier.
        /// </summary>
        public Guid? LitterId { get; set; }
    } // end class
} // end namespace