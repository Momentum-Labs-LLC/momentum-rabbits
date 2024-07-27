using Momentum.Rabbits.Models.Abstractions;
using NodaTime;

namespace Momentum.Rabbits.Models
{
    public class Litter : UserOwned
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets when the litter was born.
        /// </summary>
        public Instant Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the number of kits that are born alive.
        /// </summary>
        public int BornAlive { get; set; }

        /// <summary>
        /// Gets or sets the number of kits born dead.
        /// </summary>
        public int BornDead { get; set; }

        /// <summary>
        /// Gets or sets the mother.
        /// </summary>
        public Rabbit? Mother { get; set; }

        /// <summary>
        /// Gets or sets the father.
        /// </summary>
        public Rabbit? Father { get; set; }
    } // end class
} // end namespace