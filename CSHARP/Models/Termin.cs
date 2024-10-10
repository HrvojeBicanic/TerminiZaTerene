using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerminiZaTerene.Models
{
    public class Termin : Entitet
    {
        [ForeignKey("korisnik_id")]

        public Korisnik Korisnik { get; set; }
        [Column("pocetak")]
        public DateTimeOffset? Pocetak { get; set; }

        [Column("kraj")]
        public DateTimeOffset? Kraj { get; set; }
        [ForeignKey("teren_id")]        
        public Teren Teren { get; set; }
        public decimal? Cijena { get; set; }


    }
}
