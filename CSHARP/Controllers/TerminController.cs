using Microsoft.AspNetCore.Mvc;
using TerminiZaTerene.Data;
using TerminiZaTerene.Models;

namespace TerminiZaTerene.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TerminController:ControllerBase
    {
        private readonly BazaTermina _context;

        public TerminController(BazaTermina context)
        {
            _context = context;
        }

        //Rute
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Termini);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetBySifra(int id)
        {
            return Ok(_context.Termini.Find(id));
        }


        [HttpPost]
        public IActionResult Post(Termin termin)
        {
            _context.Termini.Add(termin);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, termin);
        }

        [HttpPut]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int id, Termin termin)
        {
            var terminBaza = _context.Termini.Find(id);

            // za sada ručno, kasnije mapper
            terminBaza.Korisnik = termin.Korisnik;
            terminBaza.Pocetak = termin.Pocetak;
            terminBaza.Kraj = termin.Kraj;
            terminBaza.Teren = termin.Teren;
            terminBaza.Cijena = termin.Cijena;
            

            _context.Termini.Update(terminBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno promjenjeno" });

        }

        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {
            var terminBaza = _context.Termini.Find(id);

            _context.Termini.Remove(terminBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno obrisano" });

        }
    }
}
