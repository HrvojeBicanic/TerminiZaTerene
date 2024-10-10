
using AutoMapper;
using TerminiZaTerene.Models;
using TerminiZaTerene.Models.DTO;

namespace TerminiZaTerene.Mapping
{
    public class TerminiZaTereneMappingProfile:Profile
    {
        public TerminiZaTereneMappingProfile()
        {
            // kreiramo mapiranja: izvor, odredište
            CreateMap<Korisnik, KorisnikDTORead>();
            CreateMap<KorisnikDTOInsertUpdate, Korisnik>();

            



        }


    }
}
