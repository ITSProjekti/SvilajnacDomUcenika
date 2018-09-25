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
    [Route("api/Statistike")]
    public class StatistikaController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase StatistikaController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public StatistikaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih statistika koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<StatistikaResource>> GetStatistike()
        {
            var listaStatistika = await UnitOfWork.Statistike.GetAllAsync();
            return Mapper.Map<List<Statistika>, List<StatistikaResource>>(listaStatistika.ToList());
        }

        /// <summary>
        /// Vraca jedan red iz tabele tj. jednu statistiku na osnovu prosledjenog Id-a
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStatistikuById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var statistika = await UnitOfWork.Statistike.GetAsync(id);
            var novaStatistika = Mapper.Map<Statistika, StatistikaResource>(statistika);
            if (statistika == null)
            {
                return NotFound();
            }

            return Ok(novaStatistika);
        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekoj statistici na osnovu prosledjenog Id-a 
        /// i vraca podatke o statistici koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatistika([FromRoute] int id, [FromBody] StatistikaResource statistika)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staraStatistika = await UnitOfWork.Statistike.GetAsync(id);
            if (id != staraStatistika.Id)
            {
                return BadRequest();
            }
            if (staraStatistika == null)
                return NotFound();


            statistika.Id = id;
            Mapper.Map<StatistikaResource, Statistika>(statistika, staraStatistika);
            await UnitOfWork.SaveChangesAsync();

            var novaStatistika = await UnitOfWork.Statistike.GetAsync(id);
            Mapper.Map<Statistika, StatistikaResource>(novaStatistika);
            return Ok(statistika);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. nove statistike.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostStatistika([FromBody] StatistikaResource statistika)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var novaStatistika = Mapper.Map<StatistikaResource, Statistika>(statistika);

            UnitOfWork.Statistike.Add(novaStatistika);
            await UnitOfWork.SaveChangesAsync();

            statistika = Mapper.Map<Statistika, StatistikaResource>(novaStatistika);

            return Ok(statistika);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjene statistike iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatistika([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var statistika = await UnitOfWork.Statistike.GetAsync(id);
            if (statistika == null)
            {
                return NotFound();
            }

            var novaStatistika = Mapper.Map<Statistika, StatistikaResource>(statistika);
            UnitOfWork.Statistike.Remove(statistika);
            await UnitOfWork.SaveChangesAsync();

            return Ok(novaStatistika);
        }
    }
}