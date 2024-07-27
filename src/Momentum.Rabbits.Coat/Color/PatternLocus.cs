using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class PatternAllele : Allele
    {
        public static readonly PatternAllele Agouti = 
            new PatternAllele(1, nameof(Agouti), "A", 
            """
            The 'Agouti' pattern has a multi-banded hair shaft. 
            There should be 3-5 different colored bands on the individual hairs.
            """);

        public static readonly PatternAllele Tan = 
            new PatternAllele(2, nameof(Tan), "a", 
            """
            The 'Tan' or 'Otter' pattern has a topside body color with with lighter undercolor (near the skin). 
            The underside of the rabbit will have a lighter color than the topside.
            """, 
            genotypeSymbol: "t");

        public static readonly PatternAllele Self = 
            new PatternAllele(3, nameof(Self), "a", 
            """
            The `Self` pattern should have a single color across their entire body, 
            and from the tip of the hairshaft to the skin.
            """, 
            dominance: DominanceEnum.Recessive);

        public PatternAllele(
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

    public class PatternLocus : Locus<PatternAllele>
    {
        public override IEnumerable<PatternAllele> Alleles => 
            new List<PatternAllele>() 
            { 
                PatternAllele.Agouti,
                PatternAllele.Tan,
                PatternAllele.Self                
            };

        public PatternLocus()
        {
            Name = "Hair Shaft Pattern";
            Description = "ASIP (Agouti Signaling Protein) provides the pattern of individual hair shafts.";
            Symbol = "A";
        } // end method
    } // end class
} // end namespace