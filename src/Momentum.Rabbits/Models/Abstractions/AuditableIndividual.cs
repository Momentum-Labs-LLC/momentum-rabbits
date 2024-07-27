using Momentum.Genetics.Heredity.Models;
using NodaTime;

namespace Momentum.Rabbits.Models.Abstractions
{
    public abstract class AuditableIndividual : Individual
    {
        /// <summary>
        /// Gets or sets the timestamp of the last update.
        /// </summary>
        public Instant LastUpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the last user to update the record.
        /// </summary>
        public Guid? LastUpdatedBy { get; set; }
    } // end class
} // end namespace