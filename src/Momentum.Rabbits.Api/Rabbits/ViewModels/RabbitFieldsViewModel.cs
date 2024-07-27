namespace Momentum.Rabbits.Api.Rabbits.ViewModels
{
    public class RabbitFieldsViewModel
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid? PaternalId { get; set; }
        public Guid? MaternalId { get; set; }
    } // end class
} // end namespace