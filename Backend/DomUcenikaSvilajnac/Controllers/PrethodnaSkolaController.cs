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
    [Route("api/OsnovneSkole")]
    public class PrethodnaSkolaController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Inicijalizacija instance klase PostanskiBrojController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public PrethodnaSkolaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IEnumerable<PrethodnaSkolaResource>> GetPrethodneSkole()
        {
            var listaPrethodnihSkoli = await UnitOfWork.PrethodneSkole.GetAllAsync();
            return Mapper.Map<List<PrethodnaSkola>, List<PrethodnaSkolaResource>>(listaPrethodnihSkoli.ToList());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPrethodnaSkolaById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prethodnaSkola = await UnitOfWork.PrethodneSkole.GetAsync(id);
            var novaPrethodnaSkola = Mapper.Map<PrethodnaSkola, PrethodnaSkolaResource>(prethodnaSkola);
            if (prethodnaSkola == null)
            {
                return NotFound();
            }

            return Ok(novaPrethodnaSkola);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPrethodneSkole([FromRoute] int id, [FromBody] PrethodnaSkolaResource prethodnaSkola)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staraPrethodnaSkola = await UnitOfWork.PrethodneSkole.GetAsync(id);
            if (id != staraPrethodnaSkola.Id)
            {
                return BadRequest();
            }
            if (staraPrethodnaSkola == null)
                return NotFound();


            prethodnaSkola.Id = id;
            Mapper.Map<PrethodnaSkolaResource, PrethodnaSkola>(prethodnaSkola, staraPrethodnaSkola);

            await UnitOfWork.SaveChangesAsync();

            var novaPrethodnaSkola = await UnitOfWork.PrethodneSkole.GetAsync(id);
            Mapper.Map<PrethodnaSkola, PrethodnaSkolaResource>(novaPrethodnaSkola);
            return Ok(prethodnaSkola);
        }

        [HttpPost]
        public async Task<IActionResult> PostPrethodnuSkolu([FromBody]  PrethodnaSkolaResource prethodnaSkola)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var novaPrethodnaSkola = Mapper.Map<PrethodnaSkolaResource, PrethodnaSkola>(prethodnaSkola);

            UnitOfWork.PrethodneSkole.Add(novaPrethodnaSkola);
            await UnitOfWork.SaveChangesAsync();

            prethodnaSkola = Mapper.Map<PrethodnaSkola, PrethodnaSkolaResource>(novaPrethodnaSkola);

            return Ok(novaPrethodnaSkola);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePrethodnaSkola([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var prethodnaSkola = await UnitOfWork.PrethodneSkole.GetAsync(id);
            if (prethodnaSkola == null)
            {
                return NotFound();
            }
            var novaPrethodnaSkola = Mapper.Map<PrethodnaSkola, PrethodnaSkolaResource>(prethodnaSkola);
            UnitOfWork.PrethodneSkole.Remove(prethodnaSkola);
            await UnitOfWork.SaveChangesAsync();

            return Ok(novaPrethodnaSkola);
        }



    }
}