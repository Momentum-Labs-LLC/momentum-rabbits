using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class ConcentrationAllele : Allele
    {
        public static readonly ConcentrationAllele FullColor = 
            new ConcentrationAllele(1, "Full Color", "C", 
            "Full yellow, no appearance change.");
        public static readonly ConcentrationAllele ChinchillaDark = 
            new ConcentrationAllele(2, "Chinchilla Dark", "c", 
            """
            'Dark Chinchilla' removes all yellow and leaves black or brown.
            This gene can also cause blue eyes in 'self chins'.
            """, 
            genotypeSymbol: "chd");

        public static readonly ConcentrationAllele ChinchillaLight = 
            new ConcentrationAllele(3, "Chinchilla Light", "c", 
            """
            'Light Chinchilla' removes some yellow, and leaves black or brown. 
            Homozygous c(chl) produces Seal.
            Heterozygous c(chl)/_ produces Sable. 
            Lightens pigments and keeps extremeties darker than the body.
            """, 
            genotypeSymbol: "chl", dominance: DominanceEnum.Incomplete);
        public static readonly ConcentrationAllele Himalayan = 
            new ConcentrationAllele(4, nameof(Himalayan), "c", 
            """
            'Himalayan' removes all color including eyes, but not on the extremities.
            c(h)/c results in abbreviated extremity markings.
            """, 
            genotypeSymbol: "h", dominance: DominanceEnum.Incomplete);
        public static readonly ConcentrationAllele Eraser = 
            new ConcentrationAllele(5, nameof(Eraser), "c", 
            """
            'Eraser' removes all colors from all areas of the rabbit, including the eyes.
            REW (Ruby-eyed white). Overrides all others when homozygous.
            """, 
            dominance: DominanceEnum.Recessive);

        public ConcentrationAllele(
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

    public class ConcentrationLocus : Locus<ConcentrationAllele>
    {
        public override IEnumerable<ConcentrationAllele> Alleles => 
            new List<ConcentrationAllele>() 
            {
                ConcentrationAllele.FullColor,
                ConcentrationAllele.ChinchillaDark,
                ConcentrationAllele.ChinchillaLight,
                ConcentrationAllele.Himalayan,
                ConcentrationAllele.Eraser
            };

        public ConcentrationLocus()
        {
            Name = "Color Concentration";
            Symbol = "C";
            Description = """
            Tyrosina (TYR) 
            Each hair shaft is painted yellow along the entire length, then black or chocolate on top of that. 
            This gene series removes yellow from the hair shafts in varying degrees.
            Some genes remove more than just yellow.
            """;
        } // end method        
    } // end class
} // end namespace