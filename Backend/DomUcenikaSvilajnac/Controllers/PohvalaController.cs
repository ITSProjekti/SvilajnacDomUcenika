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
    [Route("api/Pohvale")]
    public class PohvalaController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase PolController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public PohvalaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih polova koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<PohvalaResource>> GetPohvale()
        {
            var listaPohvala = await UnitOfWork.Pohvale.GetAllAsync();
            return Mapper.Map<List<Pohvala>, List<PohvalaResource>>(listaPohvala.ToList());
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<PohvalaResource>> GetPohvaluById([FromRoute] int id)
        {
            return await UnitOfWork.pohvaleUcenikaById(id);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPohvala([FromRoute] int id, [FromBody] PohvalaResource pohvala)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staraPohvala = await UnitOfWork.Pohvale.GetAsync(id);
            if (id != staraPohvala.Id)
            {
                return BadRequest();
            }
            if (staraPohvala == null)
                return NotFound();


            pohvala.Id = id;
            Mapper.Map<PohvalaResource, Pohvala>(pohvala, staraPohvala);
            await UnitOfWork.SaveChangesAsync();

            var novaPohvala = await UnitOfWork.Pohvale.GetAsync(id);
            Mapper.Map<Pohvala, PohvalaResource>(novaPohvala);
            return Ok(pohvala);
        }
        [HttpPost]
        public async Task<IActionResult> PostPohvala([FromBody] PohvalaResource pohvala)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var novaPohvala = Mapper.Map<PohvalaResource, Pohvala>(pohvala);

            UnitOfWork.Pohvale.Add(novaPohvala);
            await UnitOfWork.SaveChangesAsync();

            pohvala = Mapper.Map<Pohvala, PohvalaResource>(novaPohvala);

            return Ok(pohvala);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePohvala([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pohvala = await UnitOfWork.Pohvale.GetAsync(id);
            if (pohvala == null)
            {
                return NotFound();
            }

            var novaPohvala = Mapper.Map<Pohvala, PohvalaResource>(pohvala);
            UnitOfWork.Pohvale.Remove(pohvala);
            await UnitOfWork.SaveChangesAsync();

            return Ok(novaPohvala);
        }




    }
}