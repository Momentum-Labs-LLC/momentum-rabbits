namespace Momentum.Rabbits.Models
{

    /// <summary>
    /// A way to record the various length/distance measurements of a rabbit.
    /// </summary>
    public class RabbitMeasurement : RabbitMetric<decimal>
    {
        /// <summary>
        /// Gets or sets what measurement is being taken.
        /// </summary>
        public Measurement Measurement { get; set; }

        /// <summary>
        /// Gets or sets the length unit.
        /// </summary>
        public DistanceUnitEnum Unit { get; set; }
    } // end class
} // end namespace