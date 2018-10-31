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
    [Route("api/StatusiPrijave")]
    public class StatusPrijaveController : Controller
    {

        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase PolController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public StatusPrijaveController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih polova koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<StatusPrijaveResource>> GetStatusePrijave()
        {
            var statusiPrijave = await UnitOfWork.StatusiPrijave.GetAllAsync();
            return Mapper.Map<List<StatusPrijave>, List<StatusPrijaveResource>>(statusiPrijave.ToList());
        }

        /// <summary>
        /// Vraca jedan red iz tabele tj. jednu statistiku na osnovu prosledjenog Id-a
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStatusPrijaveById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var statusPrijave = await UnitOfWork.StatusiPrijave.GetAsync(id);
            var noviStatusPrijave = Mapper.Map<StatusPrijave, StatusPrijaveResource>(statusPrijave);
            if (statusPrijave == null)
            {
                return NotFound();
            }

            return Ok(noviStatusPrijave);
        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom statusuPrijave na osnovu prosledjenog Id-a 
        /// i vraca podatke o statusuPrijave koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatusPrijave([FromRoute] int id, [FromBody] StatusPrijaveResource statusPrijave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariStatusPrijave = await UnitOfWork.StatusiPrijave.GetAsync(id);
            if (id != stariStatusPrijave.Id)
            {
                return BadRequest();
            }
            if (stariStatusPrijave == null)
                return NotFound();


            statusPrijave.Id = id;
            Mapper.Map<StatusPrijaveResource, StatusPrijave>(statusPrijave, stariStatusPrijave);
            await UnitOfWork.SaveChangesAsync();

            var noviStatusPrijave = await UnitOfWork.StatusiPrijave.GetAsync(id);
            Mapper.Map<StatusPrijave, StatusPrijaveResource>(noviStatusPrijave);

            return Ok(noviStatusPrijave);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog statusaPrijave.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostStatusPrijave([FromBody] StatusPrijaveResource statusPrijave)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviStatusPrijave = Mapper.Map<StatusPrijaveResource, StatusPrijave>(statusPrijave);

            UnitOfWork.StatusiPrijave.Add(noviStatusPrijave);
            await UnitOfWork.SaveChangesAsync();

            statusPrijave = Mapper.Map<StatusPrijave, StatusPrijaveResource>(noviStatusPrijave);

            return Ok(statusPrijave);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog statusaPrijave iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatusPrijave([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var statusPrijave = await UnitOfWork.StatusiPrijave.GetAsync(id);
            if (statusPrijave == null)
            {
                return NotFound();
            }

            var noviPol = Mapper.Map<StatusPrijave, StatusPrijaveResource>(statusPrijave);
            UnitOfWork.StatusiPrijave.Remove(statusPrijave);


            await UnitOfWork.SaveChangesAsync();
            return Ok(noviPol);
        }

    }
}