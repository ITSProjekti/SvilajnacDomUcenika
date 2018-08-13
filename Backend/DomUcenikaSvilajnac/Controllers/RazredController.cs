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
        /// Inicijalizacija instance klase RazredController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public RazredController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }
        /// <summary>
        /// Vraca listu svih razreda koji se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<RazredResource>> GetRazredi()
        {
            var listaRazreda = await UnitOfWork.Razredi.GetAllAsync();
            return Mapper.Map<List<Razred>, List<RazredResource>>(listaRazreda.ToList());
        }
        /// <summary>
        /// Vraca jedan red iz tabele, tj. jedan razred na osnovu prosledjenog Id-a.
        /// </summary>
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
        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom razredu na osnovu prosledjenog Id-a 
        /// i vraca podatke o razredu koji su namenjeni za front.
        /// </summary>
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
        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog razred.
        /// </summary>
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
        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog razreda iz tabele.
        /// </summary>
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