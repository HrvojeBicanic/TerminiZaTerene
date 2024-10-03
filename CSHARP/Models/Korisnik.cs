using System.ComponentModel.DataAnnotations.Schema;

namespace TerminiZaTerene.Models
{
    public class Korisnik : Entitet
    {
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        [Column("broj_mob")]
        public string? BrojMob { get; set; }
        public string? Email { get; set; }
        public string? Lozinka { get; set; }
    }
}
