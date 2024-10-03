using System.ComponentModel.DataAnnotations;

namespace TerminiZaTerene.Models
{
    public abstract class Entitet
    {
        [Key]
        public int? Id { get; set; }

    }
}
