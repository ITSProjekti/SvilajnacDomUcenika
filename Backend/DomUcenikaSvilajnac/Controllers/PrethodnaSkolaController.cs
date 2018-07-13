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
        /// Inicijalizacija instance klase PrethodnaSkolaController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public PrethodnaSkolaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }
        /// <summary>
        /// Vraca listu svih osnovnih skola koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<PrethodnaSkolaResource>> GetPrethodneSkole()
        {
            var listaPrethodnihSkoli = await UnitOfWork.PrethodneSkole.GetAllAsync();
            return Mapper.Map<List<PrethodnaSkola>, List<PrethodnaSkolaResource>>(listaPrethodnihSkoli.ToList());
        }
        /// <summary>
        /// Vraca jedan red iz tabele, tj. osnovnu skolu na osnovu prosledjenog Id-a.
        /// </summary>
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
        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekoj osnovnoj skoli na osnovu prosledjenog Id-a 
        /// i vraca podatke o stepenu strucne spreme koji su namenjeni za front.
        /// </summary>
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
        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novoe osnovne skole.
        /// </summary>
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
        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjene osnovne skole iz tabele.
        /// </summary>
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