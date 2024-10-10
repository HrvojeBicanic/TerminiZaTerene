using AutoMapper;
using TerminiZaTerene.Data;
using TerminiZaTerene.Models;
using Microsoft.AspNetCore.Mvc;

namespace TerminiZaTerene.Controllers
{
    public abstract class TerminiZaTereneController:ControllerBase
    {
        // dependecy injection
        // 1. definiraš privatno svojstvo
        protected readonly BazaTermina _context;

        protected readonly IMapper _mapper;


        // dependecy injection
        // 2. proslijediš instancu kroz konstruktor
        public TerminiZaTereneController(BazaTermina context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
