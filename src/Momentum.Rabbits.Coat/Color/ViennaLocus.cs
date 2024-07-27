using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class ViennaAllele : Allele
    {
        public static readonly ViennaAllele NoEffect = 
            new ViennaAllele(1, "None", "V", 
            "Heterozygous (Vv) causes a broken pattern.", 
            dominance: DominanceEnum.Incomplete);
        public static readonly ViennaAllele Vienna = 
            new ViennaAllele(1, nameof(Vienna), "v", 
            "Homozygous (vv) causes BEW (Blue Eyed White).", 
            dominance: DominanceEnum.Recessive);
        public ViennaAllele(
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
    public class ViennaLocus : Locus<ViennaAllele>
    {
        public override IEnumerable<ViennaAllele> Alleles => 
            new List<ViennaAllele>() 
            {
                ViennaAllele.NoEffect,
                ViennaAllele.Vienna
            };

        public ViennaLocus()
        {
            Name = "Vienna";
            Symbol = "V";
            Description = """
            "Heterozygous (Vv) causes a broken pattern, while homozygous (vv) causes BEW.", 
            """;
        } // end method
    } // end class
} // end namespace