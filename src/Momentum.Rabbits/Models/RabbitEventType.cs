using NodaTime;

namespace Momentum.Rabbits.Models
{
    /// <summary>
    /// An event with regards to a specific rabbit.
    /// </summary>
    public class RabbitEventType
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets the creation timestamp.
        /// </summary>
        public Instant CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets if the event is available.
        /// </summary>
        public bool IsAvailable { get; set; }

    } // end class
} // end namespace