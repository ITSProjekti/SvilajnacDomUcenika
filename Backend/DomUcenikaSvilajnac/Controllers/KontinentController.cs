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
    [Route("api/Kontinenti")]
    public class KontinentController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase DrzavaController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public KontinentController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<KontinentResource>> GetKontinent()
        {
            var listaKontinenata = await UnitOfWork.Kontinenti.GetAllAsync();
            return Mapper.Map<List<Kontinent>, List<KontinentResource>>(listaKontinenata.ToList());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetKontinentById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kontinent = await UnitOfWork.Kontinenti.GetAsync(id);
            var kontinentNovi = Mapper.Map<Kontinent, KontinentResource>(kontinent);
            if (kontinent == null)
            {
                return NotFound();
            }

            return Ok(kontinentNovi);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKontinent([FromRoute] int id, [FromBody] KontinentResource kontinent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariKontinent = await UnitOfWork.Kontinenti.GetAsync(id);
            if (id != stariKontinent.Id)
            {
                return BadRequest();
            }
            if (stariKontinent == null)
                return NotFound();


            kontinent.Id = id;
            Mapper.Map<KontinentResource, Kontinent>(kontinent, stariKontinent);
            await UnitOfWork.SaveChangesAsync();

            var noviKontinent = await UnitOfWork.Kontinenti.GetAsync(id);
            Mapper.Map<Kontinent, KontinentResource>(noviKontinent);
            return Ok(kontinent);
        }

        [HttpPost]
        public async Task<IActionResult> PostKontinent([FromBody] KontinentResource kontinent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviKontinent = Mapper.Map<KontinentResource, Kontinent>(kontinent);

            UnitOfWork.Kontinenti.Add(noviKontinent);
            await UnitOfWork.SaveChangesAsync();

            kontinent = Mapper.Map<Kontinent, KontinentResource>(noviKontinent);

            return Ok(noviKontinent);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKontinent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kontinent = await UnitOfWork.Kontinenti.GetAsync(id);
            if (kontinent == null)
            {
                return NotFound();
            }

            var noviKontinent = Mapper.Map<Kontinent, KontinentResource>(kontinent);
            UnitOfWork.Kontinenti.Remove(kontinent);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviKontinent);
        }

    }
}