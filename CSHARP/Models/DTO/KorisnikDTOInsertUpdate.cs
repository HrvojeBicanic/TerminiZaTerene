

using System.ComponentModel.DataAnnotations;

namespace TerminiZaTerene.Models.DTO
{
    public record KorisnikDTOInsertUpdate(
        [Required(ErrorMessage = "Ime obavezno")]
        string Ime,
        [Required(ErrorMessage = "Prezimeme obavezno")]
        string Prezime,
        [Required(ErrorMessage = "Kontakt broj obavezan")]
        string BrojMob,
        string? Email,
        [Required(ErrorMessage = "Lozinka obavezna")]
        string Lozinka
        );
    
}
