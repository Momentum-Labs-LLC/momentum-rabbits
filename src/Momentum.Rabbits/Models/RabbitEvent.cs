using Momentum.Rabbits.Models.Abstractions;
using NodaTime;

namespace Momentum.Rabbits.Models
{
    public class RabbitEvent : UserOwned
    {
        public Guid Id { get; set; }
        public Guid RabbitId { get; set; }
        public Instant Timestamp { get; set; }
        public RabbitEventType EventType { get; set; }        
        public string? Notes { get; set; }
    } // end class
} // end namespace