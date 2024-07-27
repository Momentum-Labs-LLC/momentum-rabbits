using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class ExtensionAllele : Allele
    {
        public static readonly ExtensionAllele Steel = 
            new ExtensionAllele(1, nameof(Steel), "E", 
            """
            'Steel' creates 'tipping' on the ends of the hair shaft.
            Hairs can be 'tipped' with silver or gold.
            Fully expressed in Agouti rabbits and rarely seen in tan patterns.
            Gold ticking comes from the full extension C coloring gene.
            Silver ticking comes from the chinchilla gene c(chd). Which removes yellow, resulting in white.
            E(s)/E(s) show as `Steel` in Agouti pattern rabbits, and ticked guard hairs in self and tan patterns.
            E(s)/E shows as `Steel` in Agouti, and hides in self and tan rabbits.
            E(s)/E(j) hides as a black. 
            E(s)/e hides as a black.
            """, 
            genotypeSymbol: "s", 
            dominance: DominanceEnum.Incomplete);
        public static readonly ExtensionAllele FullExtension = 
            new ExtensionAllele(2, "FullExtension", "E", 
            """
            `Full extension` is the most common gene and does not impact appearance.
            """, 
            dominance: DominanceEnum.Incomplete);

        public static readonly ExtensionAllele Harlequin = 
            new ExtensionAllele(3, nameof(Harlequin), "e", 
            """
            `Harlequin` causes the base color to appear in patches, instead of on each hair.
            This different extension by hair shaft, results in harlequin, tricolor, japanese brindling. 
            An Agouti (A_) or Tan (a(t)_) with normal extension and this allele, E/e(j), results in a \"harlequinized\" rabbit.
            Some people would mark this gene as e(h).
            """, 
            genotypeSymbol: "j",
            dominance: DominanceEnum.Incomplete);
        public static readonly ExtensionAllele None = 
            new ExtensionAllele(4, nameof(None), "e", 
            """
            `None` or non-extension prevents the base color from moving along the hairshaft.
            Where there is shorter fur you may see the base color. 
            """, 
            dominance: DominanceEnum.Recessive);

        public ExtensionAllele(
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
    public class ExtensionLocus : Locus<ExtensionAllele>
    {
        public override IEnumerable<ExtensionAllele> Alleles =>
            new List<ExtensionAllele>() 
            {
                ExtensionAllele.Steel,
                ExtensionAllele.FullExtension,
                ExtensionAllele.Harlequin,
                ExtensionAllele.None
            };
        
        public ExtensionLocus()
        {
            Name = "Color Extension";
            Symbol = "E";
            Description = """
            MC1R (melanocortin 1 receptor)
            The Extension gene series impacts how base color moves along a hair shaft.
            More extensions causes the tipping to extend further down the hair shaft.
            """;
        } // end method
    } // end class
} // end namespace