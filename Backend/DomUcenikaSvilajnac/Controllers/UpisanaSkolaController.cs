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
    [Route("api/SrednjeSkole")]
    public class UpisanaSkolaController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase UpisanaSkolaController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public UpisanaSkolaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }
        /// <summary>
        /// Vraca listu svih srednjih skola koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<UpisanaSkolaResource>> GetSrednjeSkole()
        {
            var listaSrednjihSkola = await UnitOfWork.UpisaneSkole.GetAllAsync();
            return Mapper.Map<List<UpisanaSkola>, List<UpisanaSkolaResource>>(listaSrednjihSkola.ToList());
        }
        /// <summary>
        /// Vraca jedan red iz tabele, tj. srednju skolu na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSrednjaSkolaById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var srednjaSkola = await UnitOfWork.UpisaneSkole.GetAsync(id);
            var novaSrednjaSkola = Mapper.Map<UpisanaSkola, UpisanaSkolaResource>(srednjaSkola);
            if (srednjaSkola == null)
            {
                return NotFound();
            }

            return Ok(novaSrednjaSkola);
        }
        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekoj srednjoj skoli na osnovu prosledjenog Id-a 
        /// i vraca podatke o stepenu strucne spreme koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSrednjaSkola([FromRoute] int id, [FromBody] UpisanaSkolaResource srednjaSkola)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staraSrednjaSkola = await UnitOfWork.UpisaneSkole.GetAsync(id);
            if (id != staraSrednjaSkola.Id)
            {
                return BadRequest();
            }
            if (staraSrednjaSkola == null)
                return NotFound();


            srednjaSkola.Id = id;

            Mapper.Map<UpisanaSkolaResource, UpisanaSkola>(srednjaSkola, staraSrednjaSkola);
            await UnitOfWork.SaveChangesAsync();

            var novaSrednjaSkola = await UnitOfWork.UpisaneSkole.GetAsync(id);
            Mapper.Map<UpisanaSkola, UpisanaSkolaResource>(novaSrednjaSkola);
            return Ok(srednjaSkola);
        }
        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novoe srednje skole.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostSrednjaSkola([FromBody] UpisanaSkolaResource srednjaSkola)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var novaSrednjaSkola = Mapper.Map<UpisanaSkolaResource, UpisanaSkola>(srednjaSkola);

            UnitOfWork.UpisaneSkole.Add(novaSrednjaSkola);
            await UnitOfWork.SaveChangesAsync();

            srednjaSkola = Mapper.Map<UpisanaSkola, UpisanaSkolaResource>(novaSrednjaSkola);

            return Ok(srednjaSkola);
        }
        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjene srednje skole iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSrednjaSkola([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var srednjaSkola = await UnitOfWork.UpisaneSkole.GetAsync(id);
            if (srednjaSkola == null)
            {
                return NotFound();
            }

            var novaSrednjaSkola = Mapper.Map<UpisanaSkola, UpisanaSkolaResource>(srednjaSkola);
            UnitOfWork.UpisaneSkole.Remove(srednjaSkola);
            await UnitOfWork.SaveChangesAsync();

            return Ok(novaSrednjaSkola);
        }
    }
}