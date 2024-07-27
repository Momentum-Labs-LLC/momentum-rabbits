namespace Momentum.Rabbits.Models
{
    /// <summary>
    /// A lookup table of different rabbit measurements.
    /// </summary>
    public class Measurement
    {
        /// <summary>
        /// Gets or sets the measurement identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the measurement name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the measurement.
        /// </summary>
        public string? Description { get; set; }
    } // end class
} // end namespace