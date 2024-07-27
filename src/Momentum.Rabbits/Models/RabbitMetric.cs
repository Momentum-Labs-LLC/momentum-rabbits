using Momentum.Rabbits.Models.Abstractions;
using NodaTime;

namespace Momentum.Rabbits.Models
{
    /// <summary>
    /// A base class for the weight/measurement/sex of a rabbit.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public abstract class RabbitMetric<TValue> : UserOwned
    {
        /// <summary>
        /// Gets or sets the identifier of the metric.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the rabbit.
        /// </summary>
        public Guid RabbitId { get; set; }

        /// <summary>
        /// Gets or sets the value of the metric.
        /// </summary>
        public TValue Value { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        public Instant Timestamp { get; set; }
    } // end class
} // end namespace