using Momentum.Rabbits.Models.Abstractions;

namespace Momentum.Rabbits.Models
{
    public class RabbitGroup : UserOwned
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Rabbit> Rabbits { get; set; }
    } // end class
} // end namespace