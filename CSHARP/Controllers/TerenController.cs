using Microsoft.AspNetCore.Mvc;
using TerminiZaTerene.Data;
using TerminiZaTerene.Models;

namespace TerminiZaTerene.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TerenController:ControllerBase
    {
        private readonly BazaTermina _context;

        public TerenController(BazaTermina context)
        {
            _context = context;
        }

        //Rute
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Tereni);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetBySifra(int id)
        {
            return Ok(_context.Tereni.Find(id));
        }

        [HttpPost]
        public IActionResult Post(Teren teren)
        {
            _context.Tereni.Add(teren);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, teren);
        }

        [HttpPut]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Put(int id, Teren teren)
        {
            var terenBaza = _context.Tereni.Find(id);

            // za sada ručno, kasnije mapper
            terenBaza.NazivTerena = teren.NazivTerena;
            terenBaza.TipTerena = teren.TipTerena;
            

            _context.Tereni.Update(terenBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno promjenjeno" });
        }

        [HttpDelete]
        [Route("{id:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {
            var terenBaza = _context.Tereni.Find(id);

            _context.Tereni.Remove(terenBaza);
            _context.SaveChanges();

            return Ok(new { poruka = "Uspješno obrisano" });

        }
    }
}
