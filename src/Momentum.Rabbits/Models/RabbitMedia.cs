using NodaTime;

namespace Momentum.Rabbits.Models
{
    public class RabbitMedia
    {
        /// <summary>
        /// Gets or sets an identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the rabbit identifier.
        /// </summary>
        public Guid RabbitId { get; set; }

        /// <summary>
        /// Gets or sets the location of the media.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string? Description { get; set;}

        /// <summary>
        /// Gets or sets when the media was created.
        /// </summary>
        public Instant CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets when the media was removed.
        /// </summary>
        public Instant? DeletedAt { get; set; }
    } // end class
} // end namespace