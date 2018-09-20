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
    [Route("api/Sastanci")]
    public class SastanakController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase SastanakController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public SastanakController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih Sastanaka koji se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<SastanakResource>> GetSastanci()
        {
            //var listaSastanaka = await UnitOfWork.Sastanci.GetAllAsync();
            //return Mapper.Map<List<Sastanak>, List<SastanakResource>>(listaSastanaka.ToList());
            return await UnitOfWork.sviSastanci();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSastanakById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapiranSastanak = await UnitOfWork.sastanakById(id);

            var sastanak = await UnitOfWork.Sastanci.GetAsync(id);
            var noviSastanak = Mapper.Map<Sastanak, SastanakResource>(sastanak);
            if (sastanak == null)
            {
                return NotFound();
            }

            return Ok(noviSastanak);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSastanak([FromRoute] int id, [FromBody] SastanakResource sastanak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariSastanak = await UnitOfWork.Sastanci.GetAsync(id);
            if (id != stariSastanak.Id)
            {
                return BadRequest();
            }
            if (stariSastanak == null)
                return NotFound();


            sastanak.Id = id;
            Mapper.Map<SastanakResource, Sastanak>(sastanak, stariSastanak);
            await UnitOfWork.SaveChangesAsync();

            var noviSastanak = await UnitOfWork.mapiranjeZaPutSastanka(id);
            
            return Ok(noviSastanak);
        }

        [HttpPost]
        public async Task<IActionResult> PostSastanak([FromBody] SastanakResource sastanak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviSastanak = Mapper.Map<SastanakResource, Sastanak>(sastanak);

            UnitOfWork.Sastanci.Add(noviSastanak);
            await UnitOfWork.SaveChangesAsync();

            sastanak = Mapper.Map<Sastanak, SastanakResource>(noviSastanak);
            var mapiranSastanak = await UnitOfWork.mapiranjeZaPostSastanka(sastanak);

            return Ok(mapiranSastanak);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSastanak([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sastanak = await UnitOfWork.Sastanci.GetAsync(id);
            if (sastanak == null)
            {
                return NotFound();
            }
            
            var noviSastanak = Mapper.Map<Sastanak, SastanakResource>(sastanak);
            var mapiranSastanak = await UnitOfWork.mapiranjeZaDeleteSastanka(noviSastanak);
            UnitOfWork.Sastanci.Remove(sastanak);
            await UnitOfWork.SaveChangesAsync();

            return Ok(mapiranSastanak);
        }
    }
}