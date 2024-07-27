using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class BrokenAllele : Allele
    {
        public static readonly BrokenAllele NotBroken = 
            new BrokenAllele(1, "Not Broken", "en",
            """
            Wild type allele.
            Homozygous en/en - no broken pattern.
            Heterozygous en/En - spotting/broken pattern.
            """, 
            dominance: DominanceEnum.Codominant);
        public static readonly BrokenAllele Broken = 
            new BrokenAllele(2, nameof(Broken), "En", 
            """
            Homozygous (EnEn) will be almost all white, commonly called Charlie.
            Heterozygous (Enen) will be typical spotting.
            """, 
            dominance: DominanceEnum.Codominant);

        public BrokenAllele(
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

    public class BrokenLocus : Locus<BrokenAllele>
    {
        public override IEnumerable<BrokenAllele> Alleles =>
            new List<BrokenAllele>()
            {
                BrokenAllele.NotBroken,
                BrokenAllele.Broken
            };
        
        public BrokenLocus()
        {
            Name = "Broken/English";
            Symbol = "En";
            Description = """
            Controls white spotting on the coat., 
            """;
        } // end method
    } // end class
} // end namespace