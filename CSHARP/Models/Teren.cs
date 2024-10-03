using System.ComponentModel.DataAnnotations.Schema;

namespace TerminiZaTerene.Models
{
    public class Teren : Entitet
    {
        [Column("naziv_terena")]
        public string? NazivTerena  { get; set; }
        [Column("tip_terena")]
        public string? TipTerena { get; set; }

    }
}