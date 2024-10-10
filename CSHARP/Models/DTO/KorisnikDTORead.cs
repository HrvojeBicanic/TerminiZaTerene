namespace TerminiZaTerene.Models.DTO
{
    public record KorisnikDTORead(
        int Id,
        string? Ime,
        string? Prezime,
        string? BrojMob,
        string? Email,
        string? Lozinka
        );
    
}
