namespace Momentum.Rabbits.Models
{
    public class LitterEventType
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
        /// Gets or sets if this event is available. 
        /// </summary>
        public bool IsAvailable { get; set; }
    } // end enum
} // end namespace