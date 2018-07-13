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
    [Route("api/Razredi")]
    public class RazredController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase PolController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public RazredController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<RazredResource>> GetRazredi()
        {
            var listaRazreda = await UnitOfWork.Razredi.GetAllAsync();
            return Mapper.Map<List<Razred>, List<RazredResource>>(listaRazreda.ToList());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRazredById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var razred = await UnitOfWork.Razredi.GetAsync(id);
            var noviRazred = Mapper.Map<Razred, RazredResource>(razred);
            if (razred == null)
            {
                return NotFound();
            }

            return Ok(noviRazred);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRazred([FromRoute] int id, [FromBody] RazredResource razred)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariRazred = await UnitOfWork.Razredi.GetAsync(id);
            if (id != stariRazred.Id)
            {
                return BadRequest();
            }
            if (stariRazred == null)
                return NotFound();


            razred.Id = id;
            Mapper.Map<RazredResource, Razred>(razred, stariRazred);
            await UnitOfWork.SaveChangesAsync();

            var noviRazred = await UnitOfWork.Razredi.GetAsync(id);
            Mapper.Map<Razred, RazredResource>(noviRazred);
            return Ok(razred);
        }

        [HttpPost]
        public async Task<IActionResult> PostRazred([FromBody] RazredResource razred)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviRazred = Mapper.Map<RazredResource, Razred>(razred);

            UnitOfWork.Razredi.Add(noviRazred);
            await UnitOfWork.SaveChangesAsync();

            razred = Mapper.Map<Razred, RazredResource>(noviRazred);

            return Ok(noviRazred);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRazred([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var razred = await UnitOfWork.Razredi.GetAsync(id);
            if (razred == null)
            {
                return NotFound();
            }

            var noviRazred = Mapper.Map<Razred, RazredResource>(razred);
            UnitOfWork.Razredi.Remove(razred);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviRazred);
        }
    }
}