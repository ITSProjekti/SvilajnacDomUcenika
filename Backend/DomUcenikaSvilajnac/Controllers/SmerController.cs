using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using Microsoft.AspNetCore.Mvc;

namespace DomUcenikaSvilajnac.Controllers
{
    [Produces("application/json")]
    [Route("api/Smerovi")]
    public class SmerController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase SmerController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public SmerController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih smerova koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<SmerResource>> GetSmerovi()
        {
            var listaSmerova = await UnitOfWork.Smerovi.GetAllAsync();
            return Mapper.Map<List<Smer>, List<SmerResource>>(listaSmerova.ToList());
        }
        /// <summary>
        /// Vraca jedan red iz tabele, tj. smer na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSmerById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var smer = await UnitOfWork.Smerovi.GetAsync(id);
            var noviSmer = Mapper.Map<Smer, SmerResource>(smer);
            if (smer == null)
            {
                return NotFound();
            }

            return Ok(noviSmer);
        }
        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom smeru na osnovu prosledjenog Id-a 
        /// i vraca podatke o smeru koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSmer([FromRoute] int id, [FromBody] SmerResource smer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariSmer = await UnitOfWork.Smerovi.GetAsync(id);
            if (id != stariSmer.Id)
            {
                return BadRequest();
            }
            if (stariSmer == null)
                return NotFound();


            smer.Id = id;
            Mapper.Map<SmerResource, Smer>(smer, stariSmer);
            await UnitOfWork.SaveChangesAsync();

            var noviSmer = await UnitOfWork.Smerovi.GetAsync(id);
            Mapper.Map<Smer, SmerResource>(noviSmer);
            return Ok(smer);
        }
        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog smera.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostSmer([FromBody] SmerResource smer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviSmer = Mapper.Map<SmerResource, Smer>(smer);

            UnitOfWork.Smerovi.Add(noviSmer);
            await UnitOfWork.SaveChangesAsync();

            smer = Mapper.Map<Smer, SmerResource>(noviSmer);

            return Ok(smer);
        }
        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog smera iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSmer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var smer = await UnitOfWork.Smerovi.GetAsync(id);
            if (smer == null)
            {
                return NotFound();
            }

            var noviSmer = Mapper.Map<Smer, SmerResource>(smer);
            UnitOfWork.Smerovi.Remove(smer);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviSmer);
        }



    }
}