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
        /// Inicijalizacija instance klase PohvalaController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public PohvalaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih pohvala koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<PohvalaResource>> GetPohvale()
        {
            var listaPohvala = await UnitOfWork.Pohvale.GetAllAsync();
            return Mapper.Map<List<Pohvala>, List<PohvalaResource>>(listaPohvala.ToList());
        }

        /// <summary>
        /// Vraca jedan red iz tabele, tj. jednu pohvalu na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IEnumerable<PohvalaResource>> GetPohvaluById([FromRoute] int id)
        {
            return await UnitOfWork.Pohvale.pohvaleUcenikaById(id);
        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekoj pohvali na osnovu prosledjenog Id-a 
        /// i vraca podatke o pohvali koji su namenjeni za front.
        /// </summary>
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

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. nove pohvale.
        /// </summary>
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

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjene pohvale iz tabele.
        /// </summary>
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