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
    [Route("api/Polovi")]
    public class PolController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase PolController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public PolController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih polova koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<PolResource>> GetPolovi()
        {
            var listaPolova = await UnitOfWork.Polovi.GetAllAsync();
            return Mapper.Map<List<Pol>, List<PolResource>>(listaPolova.ToList());
        }

        /// <summary>
        /// Vraca jedan red iz tabele, tj. jedan pol na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPolById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pol = await UnitOfWork.Polovi.GetAsync(id);
            var noviPol = Mapper.Map<Pol, PolResource>(pol);
            if (pol == null)
            {
                return NotFound();
            }

            return Ok(noviPol);
        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom polu na osnovu prosledjenog Id-a 
        /// i vraca podatke o polu koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPol([FromRoute] int id, [FromBody] PolResource pol)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariPol = await UnitOfWork.Polovi.GetAsync(id);
            if (id != stariPol.Id)
            {
                return BadRequest();
            }
            if (stariPol == null)
                return NotFound();


            pol.Id = id;
            Mapper.Map<PolResource, Pol>(pol, stariPol);
            await UnitOfWork.SaveChangesAsync();

            var noviPol = await UnitOfWork.Polovi.GetAsync(id);
            Mapper.Map<Pol, PolResource>(noviPol);
            return Ok(pol);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog pola.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostPol([FromBody] PolResource pol)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviPol = Mapper.Map<PolResource, Pol>(pol);

            UnitOfWork.Polovi.Add(noviPol);
            await UnitOfWork.SaveChangesAsync();

            pol = Mapper.Map<Pol, PolResource>(noviPol);

            return Ok(pol);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog pola iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePol ([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pol = await UnitOfWork.Polovi.GetAsync(id);
            if (pol == null)
            {
                return NotFound();
            }

            var noviPol = Mapper.Map<Pol, PolResource>(pol);
            UnitOfWork.Polovi.Remove(pol);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviPol);
        }
    }
}