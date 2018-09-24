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
    [Route("api/Staratelji")]
    public class StarateljController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase StarateljController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public StarateljController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih staratelja koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<StarateljResource>> GetStaratelji()
        {
            var listaStaratelja = await UnitOfWork.Staratelji.GetAllAsync();
            return Mapper.Map<List<Staratelj>, List<StarateljResource>>(listaStaratelja.ToList());
        }

        /// <summary>
        /// Vraca jedan red iz tabele, tj. staratelja na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStarateljById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staratelj = await UnitOfWork.Staratelji.GetAsync(id);
            var noviStaratelj = Mapper.Map<Staratelj, StarateljResource>(staratelj);
            if (staratelj == null)
            {
                return NotFound();
            }

            return Ok(noviStaratelj);
        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom staratelju na osnovu prosledjenog Id-a 
        /// i vraca podatke o staratelju koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaratelj([FromRoute] int id, [FromBody] StarateljResource staratelj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariStaratelj = await UnitOfWork.Staratelji.GetAsync(id);
            if (id != stariStaratelj.Id)
            {
                return BadRequest();
            }
            if (stariStaratelj == null)
                return NotFound();


            staratelj.Id = id;
            Mapper.Map<StarateljResource, Staratelj>(staratelj, stariStaratelj);
            await UnitOfWork.SaveChangesAsync();

            var noviStaratelj = await UnitOfWork.Staratelji.GetAsync(id);
            Mapper.Map<Staratelj, StarateljResource>(noviStaratelj);
            return Ok(noviStaratelj);

        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog staratelja.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostStaratelj([FromBody] StarateljResource staratelj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviStaratelj = Mapper.Map<StarateljResource, Staratelj>(staratelj);

            UnitOfWork.Staratelji.Add(noviStaratelj);
            await UnitOfWork.SaveChangesAsync();

            staratelj = Mapper.Map<Staratelj, StarateljResource>(noviStaratelj);

            return Ok(staratelj);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog staratelja iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaratelj([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staratelj = await UnitOfWork.Staratelji.GetAsync(id);
            if (staratelj == null)
            {
                return NotFound();
            }

            var noviStaratelj = Mapper.Map<Staratelj, StarateljResource>(staratelj);

            UnitOfWork.Staratelji.Remove(staratelj);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviStaratelj);
        }



    }
}