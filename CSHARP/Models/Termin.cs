using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerminiZaTerene.Models
{
    public class Termin : Entitet
    {
        [ForeignKey("Korisnik")]
        [Column("korisnik_id")]
        public int KorisnikId { get; set; }
        [Column("pocetak")]
        public DateTimeOffset? Pocetak { get; set; }

        [Column("kraj")]
        public DateTimeOffset? Kraj { get; set; }
        [ForeignKey("Teren")]
        [Column("teren_id")]
        public int TerenId { get; set; }
        public decimal? Cijena { get; set; }


    }
}
