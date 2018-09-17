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
    [Route("api/StepeniStrucneSpreme")]
    public class StepenStrucneSpremeController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase StepenStrucneSpremeController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public StepenStrucneSpremeController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }
        /// <summary>
        /// Vraca listu svih stepena strucne spreme koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<StepenStrucneSpremeResource>> GetStepenStrucneSpreme()
        {
            var lisataStepena = await UnitOfWork.Stepeni.GetAllAsync();
            return Mapper.Map<List<StepenStrucneSpreme>, List<StepenStrucneSpremeResource>>(lisataStepena.ToList());
        }
        /// <summary>
        /// Vraca jedan red iz tabele, tj. stepen strucne spreme na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStepenStrucneSpremeById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stepen = await UnitOfWork.Stepeni.GetAsync(id);
            var noviStepen = Mapper.Map<StepenStrucneSpreme, StepenStrucneSpremeResource>(stepen);
            if (stepen == null)
            {
                return NotFound();
            }

            return Ok(noviStepen);
        }
        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom stepenu strucne spreme na osnovu prosledjenog Id-a 
        /// i vraca podatke o stepenu strucne spreme koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStepenStrucneSpreme([FromRoute] int id, [FromBody] StepenStrucneSpremeResource stepen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariStepen = await UnitOfWork.Stepeni.GetAsync(id);
            if (id != stariStepen.Id)
            {
                return BadRequest();
            }
            if (stariStepen == null)
                return NotFound();


            stepen.Id = id;
            Mapper.Map<StepenStrucneSpremeResource, StepenStrucneSpreme>(stepen, stariStepen);
            await UnitOfWork.SaveChangesAsync();

            var noviStepen = await UnitOfWork.Stepeni.GetAsync(id);
            Mapper.Map<StepenStrucneSpreme, StepenStrucneSpremeResource>(noviStepen);
            return Ok(stepen);
        }
        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog stepena strucne spreme.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostStepenStrucneSpreme([FromBody] StepenStrucneSpremeResource stepen)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviStepen = Mapper.Map<StepenStrucneSpremeResource, StepenStrucneSpreme>(stepen);

            UnitOfWork.Stepeni.Add(noviStepen);
            await UnitOfWork.SaveChangesAsync();

            stepen = Mapper.Map<StepenStrucneSpreme, StepenStrucneSpremeResource>(noviStepen);

            return Ok(stepen);
        }
        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog stepena strucne spreme iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStepenStrucneSpreme([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stepen = await UnitOfWork.Stepeni.GetAsync(id);
            if (stepen == null)
            {
                return NotFound();
            }

            var noviStepen = Mapper.Map<StepenStrucneSpreme, StepenStrucneSpremeResource>(stepen);
            UnitOfWork.Stepeni.Remove(stepen);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviStepen);
        }
    }
}