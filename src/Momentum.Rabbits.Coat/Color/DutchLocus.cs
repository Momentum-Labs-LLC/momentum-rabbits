using Momentum.Genetics.Models;

namespace Momentum.Rabbits.Coat.Color
{
    public class DutchAllele : Allele
    {
        public static readonly DutchAllele Dutch = 
            new DutchAllele(1, nameof(Dutch), "Du", 
            """
            Dominant allele. 
            Du/Du has no effect. 
            Heterozygous causes solid with spots.
            """, dominance: DominanceEnum.Codominant);
        
        public static readonly DutchAllele DutchWhite = 
            new DutchAllele(2, "White", "du", 
            """
            Homozygous is too much white. 
            Du/du(w) solid with spots
            du(w)/du(d) - Good Dutch.
            """, 
            genotypeSymbol: "w", 
            dominance: DominanceEnum.Codominant);
        public static readonly DutchAllele DutchSolid = 
            new DutchAllele(3, "Solid", "du", 
            """
            Homozygous du(d)/du(d) is too little white. 
            Du/du(d) solid with spots, du(d)/du(w) - Good Dutch.
            """, 
            genotypeSymbol: "d", 
            dominance: DominanceEnum.Codominant);

        public DutchAllele(
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
    public class DutchLocus : Locus<DutchAllele>
    {
        public override IEnumerable<DutchAllele> Alleles => throw new NotImplementedException();

        public DutchLocus()
        {
            Name = "Dutch";
            Symbol = "Du";
            Description = """
            This is conventional wisdom about the dutch look. 
            The recessive genes, du(w) and du(d), are primarily in the Dutch and Hotot breeds.
            """;
        } // end method
    } // end class
} // end namespace