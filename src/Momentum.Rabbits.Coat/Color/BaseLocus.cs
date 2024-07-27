using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class BaseAllele : Allele 
    {
        public static readonly BaseAllele Black = new BaseAllele(1, nameof(Black), "B", "Black base color.");
        public static readonly BaseAllele Chocolate = new BaseAllele(2, nameof(Chocolate), "b", "Chocolate base color.", dominance: DominanceEnum.Recessive);

        protected BaseAllele(
            int ordinal, 
            string name, 
            string symbol,
            string description, 
            string? genotypeSymbol = null,
            DominanceEnum dominance = DominanceEnum.Dominant)
            : base(ordinal, name, symbol, description, genotypeSymbol, dominance)
        {
        } // end method
    } // end class

    public class BaseLocus : Locus<BaseAllele>
    {
        public override IEnumerable<BaseAllele> Alleles => 
            new List<BaseAllele>() { BaseAllele.Black, BaseAllele.Chocolate };

        public BaseLocus()
        {
            Name = "Base Color";
            Symbol = "B";
            Description = "Determines the base color of the coat. All rabbits are black or chocolate.";
        } // end method
    } // end class
} // end namespace