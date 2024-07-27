using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class SilveringAllele : Allele
    {
        public static readonly SilveringAllele None = 
            new SilveringAllele(1, nameof(None), "Si", 
                "No silvering will occur.", 
                dominance: DominanceEnum.Incomplete);
        public static readonly SilveringAllele Silver = 
            new SilveringAllele(2, nameof(Silver), "si", 
            """
            Can cause silvering. 
            Si/si does not consistently cause silvering. 
            Few breeds have this allele: Silver, Silver Fox, Champagne d'Argent, Creme d'Argent
            """, 
            dominance: DominanceEnum.Incomplete);

        public SilveringAllele(
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
    public class SilveringLocus : Locus<SilveringAllele>
    {
        public override IEnumerable<SilveringAllele> Alleles => throw new NotImplementedException();

        public SilveringLocus()
        {
            Name = "Silvering";
            Symbol = "Si";
            Description = """
            Controls the silvering of the coat, where white haris are interspersed in a darker coat.
            (Silver, Champagne, Creme D'Argent)
            """;
        } // end method
    } // end class
} // end namespace