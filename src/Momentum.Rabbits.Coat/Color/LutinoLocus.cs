using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class LutinoAllele : Allele
    {
        public static readonly LutinoAllele NoEffect = 
            new LutinoAllele(1, "None", "P", 
            "No impact.", 
            dominance: DominanceEnum.Dominant);
        public static readonly LutinoAllele Lutino = 
            new LutinoAllele(1, "Lutino", "p", 
            "Lutino represented.", 
            dominance: DominanceEnum.Recessive);

        public LutinoAllele(
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
    public class LutinoLocus : Locus<LutinoAllele>
    {
        public override IEnumerable<LutinoAllele> Alleles => 
            new List<LutinoAllele>() 
            {
                LutinoAllele.NoEffect,
                LutinoAllele.Lutino
            };

        public LutinoLocus()
        {
            Name = "Lutino";
            Symbol = "P";
            Description = """
            What is lutino?
            """;
        } // end method
    } // end class
} // end namespace