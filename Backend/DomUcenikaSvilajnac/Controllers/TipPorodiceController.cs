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
    [Route("api/TipoviPorodice")]
    public class TipPorodiceController : Controller
    {

        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase TipPorodiceController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public TipPorodiceController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih tipova porodice koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<TipPorodiceResource>> GetTipovePorodice()
        {
            var listaTipovaPorodice = await UnitOfWork.TipoviPorodice.GetAllAsync();
            return Mapper.Map<List<TipPorodice>, List<TipPorodiceResource>>(listaTipovaPorodice.ToList());
        }

        /// <summary>
        /// Vraca jedan red iz tabele, tj. jedan tip porodice na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipPorodiceById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipPorodice = await UnitOfWork.TipoviPorodice.GetAsync(id);
            var noviTipPorodice = Mapper.Map<TipPorodice, TipPorodiceResource>(tipPorodice);
            if (tipPorodice == null)
            {
                return NotFound();
            }

            return Ok(noviTipPorodice);
        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom tipu porodice na osnovu prosledjenog Id-a 
        /// i vraca podatke o tipu porodice koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipPorodice([FromRoute] int id, [FromBody] TipPorodiceResource tipPorodice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariTipPorodice = await UnitOfWork.TipoviPorodice.GetAsync(id);
            if (id != stariTipPorodice.Id)
            {
                return BadRequest();
            }
            if (stariTipPorodice == null)
                return NotFound();


            tipPorodice.Id = id;


            Mapper.Map<TipPorodiceResource, TipPorodice>(tipPorodice, stariTipPorodice);
            await UnitOfWork.SaveChangesAsync();

            var noviTipPorodice = await UnitOfWork.TipoviPorodice.GetAsync(id);
            Mapper.Map<TipPorodice, TipPorodiceResource>(noviTipPorodice);
            return Ok(tipPorodice);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog tipa porodice.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostTipPorodice([FromBody] TipPorodiceResource tipPorodice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviTipPorodice = Mapper.Map<TipPorodiceResource, TipPorodice>(tipPorodice);

            UnitOfWork.TipoviPorodice.Add(noviTipPorodice);
            await UnitOfWork.SaveChangesAsync();

            tipPorodice = Mapper.Map<TipPorodice, TipPorodiceResource>(noviTipPorodice);

            return Ok(tipPorodice);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog tipa porodice iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipPorodice([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipPorodice = await UnitOfWork.TipoviPorodice.GetAsync(id);
            if (tipPorodice == null)
            {
                return NotFound();
            }

            var noviTipPorodice = Mapper.Map<TipPorodice, TipPorodiceResource>(tipPorodice);
            UnitOfWork.TipoviPorodice.Remove(tipPorodice);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviTipPorodice);
        }


    }
}