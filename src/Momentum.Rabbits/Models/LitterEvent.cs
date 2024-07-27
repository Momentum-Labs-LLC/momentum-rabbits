using Momentum.Rabbits.Models.Abstractions;
using NodaTime;

namespace Momentum.Rabbits.Models
{
    public class LitterEvent : UserOwned
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the litter identifier.
        /// </summary>
        public Guid LitterId { get; set; }    

        /// <summary>
        /// Gets or sets when the event occured.
        /// </summary>
        public Instant Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        public LitterEventType EventType { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public string Notes { get; set; }
    } // end class
} // end namespace