using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using TerminiZaTerene.Data;
using TerminiZaTerene.Models;

namespace TerminiZaTerene.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KorisnikController:ControllerBase
    {
        private readonly BazaTermina _context;

        public KorisnikController(BazaTermina context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Korisnici);
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetBySifra(int id)
        {
            return Ok(_context.Korisnici.Find(id));
        }


        [HttpPost]
        public IActionResult Post(Korisnik korisnik)
        {
            _context.Korisnici.Add(korisnik);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, korisnik);
        }


        [HttpPut]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int id, Korisnik korisnik)
        {
            var korisnikBaza = _context.Korisnici.Find(id);

            // za sada ručno, kasnije mapper
            korisnikBaza.Ime = korisnik.Ime;
            korisnikBaza.Prezime = korisnik.Prezime;
            korisnikBaza.BrojMob = korisnik.BrojMob;
            korisnikBaza.Email = korisnik.Email;
            korisnikBaza.Lozinka = korisnik.Lozinka;

            _context.Korisnici.Update(korisnikBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno promjenjeno" });

        }


        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {
            var korisnikBaza = _context.Korisnici.Find(id);

            _context.Korisnici.Remove(korisnikBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno obrisano" });

        }

    }
    }

