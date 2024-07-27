namespace Momentum.Rabbits.Models.Abstractions
{
    public abstract class UserOwned : Auditable
    {
        public Guid? UserId { get; set; }
    } // end class

    public abstract class UserOwnedIndividual : AuditableIndividual 
    {
        public Guid UserId { get; set; }
    } // end class
} // end namespace