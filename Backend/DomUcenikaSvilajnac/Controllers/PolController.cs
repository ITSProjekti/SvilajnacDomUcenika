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
        /// Inicijalizacija instance klase DrzavaController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public PolController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih drzava koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<PolResource>> GetPolovi()
        {
            var listaPolova = await UnitOfWork.Polovi.GetAllAsync();
            return Mapper.Map<List<Pol>, List<PolResource>>(listaPolova.ToList());
        }

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

            return Ok(noviPol);
        }
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