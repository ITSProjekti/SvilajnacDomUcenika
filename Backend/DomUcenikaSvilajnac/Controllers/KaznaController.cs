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
    [Route("api/Kazne")]
    public class KaznaController : Controller
    {       
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase PolController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public KaznaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih polova koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<KaznaResource>> GetKazne()
        {
            var listaKazni = await UnitOfWork.Kazne.GetAllAsync();
            return Mapper.Map<List<Kazna>, List<KaznaResource>>(listaKazni.ToList());
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<KaznaResource>> GetKaznuById([FromRoute] int id)
        {
            //ovde ces trebati da napravis isto kao za pohvale u istoj metodi

            return await UnitOfWork.kazneUcenikaById(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutKazna([FromRoute] int id, [FromBody] KaznaResource kazna)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staraKazna = await UnitOfWork.Kazne.GetAsync(id);
            if (id != staraKazna.Id)
            {
                return BadRequest();
            }
            if (staraKazna == null)
                return NotFound();


            kazna.Id = id;
            Mapper.Map<KaznaResource, Kazna>(kazna, staraKazna);
            await UnitOfWork.SaveChangesAsync();

            var novaKazna = await UnitOfWork.Kazne.GetAsync(id);
            Mapper.Map<Kazna, KaznaResource>(novaKazna);
            return Ok(kazna);
        }

        [HttpPost]
        public async Task<IActionResult> PostKazna([FromBody] KaznaResource kazna)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var novaKazna = Mapper.Map<KaznaResource, Kazna>(kazna);

            UnitOfWork.Kazne.Add(novaKazna);
            await UnitOfWork.SaveChangesAsync();

            kazna = Mapper.Map<Kazna, KaznaResource>(novaKazna);

            return Ok(kazna);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKazna([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var kazna = await UnitOfWork.Kazne.GetAsync(id);
            if (kazna == null)
            {
                return NotFound();
            }

            var novaKazna = Mapper.Map<Kazna, KaznaResource>(kazna);
            UnitOfWork.Kazne.Remove(kazna);
            await UnitOfWork.SaveChangesAsync();

            return Ok(novaKazna);
        }
    }    
}