using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class DensityAllele : Allele
    {
        public static readonly DensityAllele Intense = 
            new DensityAllele(1, nameof(Intense), "D", 
                "Intense coloration, no change.");
        public static readonly DensityAllele Dilute = 
            new DensityAllele(2, nameof(Dilute), "d", 
                "Diluted coloration", 
                dominance: DominanceEnum.Recessive);

        public DensityAllele(
            int ordinal, 
            string name, 
            string symbol, 
            string? description, 
            string? genotypeSymbol = null, 
            DominanceEnum dominance = DominanceEnum.Dominant) 
            : base(ordinal, name, symbol, description, genotypeSymbol, dominance)
        {
        } // end method
    } // end class

    public class DensityLocus : Locus<DensityAllele>
    {
        public override IEnumerable<DensityAllele> Alleles => 
            new List<DensityAllele>()
            {
                DensityAllele.Intense,
                DensityAllele.Dilute
            };
        
        public DensityLocus()
        {
            Name = "Base Color Density";
            Symbol = "D";
            Description = """
            MLPH
            If homozygous dilute (d/d) is present then black is diluted to a blue phenotype, and chocolate is diluted to a lilac phenotype.
            """;
        } // end method
    } // end class
} // end namespace