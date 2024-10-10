using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TerminiZaTerene.Data;
using TerminiZaTerene.Models;
using TerminiZaTerene.Models.DTO;

namespace TerminiZaTerene.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class KorisnikController(BazaTermina context, IMapper mapper) : TerminiZaTereneController(context, mapper)
    {



        //Rute
        [HttpGet]
        public ActionResult<List<KorisnikDTORead>> Get()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                return Ok(_mapper.Map<List<KorisnikDTORead>>(_context.Korisnici));
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });
            }


        }


        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<KorisnikDTORead> GetBySifra(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            Korisnik? e;
            try
            {
                e = _context.Korisnici.Find(id);
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });
            }
            if (e == null)
            {
                return NotFound(new { poruka = "Korisnik ne postoji u bazi" });
            }

            return Ok(_mapper.Map<KorisnikDTORead>(e));
        }


        [HttpPost]
        public IActionResult Post(KorisnikDTOInsertUpdate dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { poruka = ModelState });
            }
            try
            {
                var e = _mapper.Map<Korisnik>(dto);
                _context.Korisnici.Add(e);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, _mapper.Map<KorisnikDTORead>(e));
            }
            catch (Exception ex)
            {
                return BadRequest(new { poruka = ex.Message });
            }
        }


            [HttpPut]
            [Route("{id:int}")]
            [Produces("application/json")]
            public IActionResult Put(int id, KorisnikDTOInsertUpdate dto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new { poruka = ModelState });
                }
                try
                {
                    Korisnik? e;
                    try
                    {
                        e = _context.Korisnici.Find(id);
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(new { poruka = ex.Message });
                    }
                    if (e == null)
                    {
                        return NotFound(new { poruka = "Korisnik ne postoji u bazi" });
                    }

                    e = _mapper.Map(dto, e);

                    _context.Korisnici.Update(e);
                    _context.SaveChanges();

                    return Ok(new { poruka = "Korisnik promjenjen!" });
                }
                catch (Exception ex)
                {
                    return BadRequest(new { poruka = ex.Message });
                }


            }


            [HttpDelete]
            [Route("{id:int}")]
            [Produces("application/json")]
            public IActionResult Delete(int id)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new { poruka = ModelState });
                }
                try
                {
                    Korisnik? e;
                    try
                    {
                        e = _context.Korisnici.Find(id);
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(new { poruka = ex.Message });
                    }
                    if (e == null)
                    {
                        return NotFound("Korisnik ne postoji u bazi");
                    }
                    _context.Korisnici.Remove(e);
                    _context.SaveChanges();
                    return Ok(new { poruka = "Korisnik obrisan!" });
                }
                catch (Exception ex)
                {
                    return BadRequest(new { poruka = ex.Message });
                }
            }



        }
    }


