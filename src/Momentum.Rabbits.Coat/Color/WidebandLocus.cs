using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class WidebandAllele : Allele
    {
        public static readonly WidebandAllele Standard = 
            new WidebandAllele(1, nameof(Standard), "W", 
                "No expression of wideband.");
        public static readonly WidebandAllele Wideband = 
            new WidebandAllele(2, nameof(Wideband), "w", 
            "Doubles the width of the 'red' bands in agouti rabbits.", 
            dominance: DominanceEnum.Recessive);

        public WidebandAllele(
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
    public class WidebandLocus : Locus<WidebandAllele>
    {
        public override IEnumerable<WidebandAllele> Alleles => throw new NotImplementedException();

        public WidebandLocus()
        {
            Name = "Wideband";
            Symbol = "W";
            Description = """
            ww doubles the width of the 'red' bands in agouti rabbits, 
            and may eliminate belly undercolor of tan and agouti patterns, 
            shows yellow more vibrantly.
            (Tan, Belgian Hare, Flemish Sandy)
            """;
        } // end method
    } // end class
} // end namespace