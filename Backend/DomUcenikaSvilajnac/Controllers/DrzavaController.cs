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
    [Route("api/Drzave")]
    public class DrzavaController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase DrzavaController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public DrzavaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih drzava koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<DrzavaResource>> GetDrzave()
        {
            var listaDrzava = await UnitOfWork.Drzave.GetAllAsync();
            return Mapper.Map<List<Drzava>, List<DrzavaResource>>(listaDrzava.ToList());
        }

        /// <summary>
        /// Vraca jedan red iz tabele, tj. jednu drzavu na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDrzavaById([FromRoute] int id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //var drzava = await UnitOfWork.Drzave.GetAsync(id);
            //var drzavaNova = Mapper.Map<Drzava, DrzavaResource>(drzava);
            //if (drzava == null)
            //{
            //    return NotFound();
            //}
          var nesto = await  UnitOfWork.GetDrzaveKontinente(id);



            return Ok(nesto);
        }
        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekoj drzavi na osnovu prosledjenog Id-a 
        /// i vraca podatke o drzavi koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrzava([FromRoute] int id, [FromBody] DrzavaResource drzava)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staraDrzava = await UnitOfWork.Drzave.GetAsync(id);
            if (id != staraDrzava.Id)
            {
                return BadRequest();
            }
            if (staraDrzava == null)
                return NotFound();


            drzava.Id = id;
            Mapper.Map<DrzavaResource, Drzava>(drzava, staraDrzava);
            await UnitOfWork.SaveChangesAsync();

            var novaDrzava = await UnitOfWork.Drzave.GetAsync(id);
            Mapper.Map<Drzava, DrzavaResource>(novaDrzava);
            return Ok(drzava);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. nove drzave.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostDrzava([FromBody] DrzavaResource drzava)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var novaDrzava = Mapper.Map<DrzavaResource, Drzava>(drzava);

            UnitOfWork.Drzave.Add(novaDrzava);
            await UnitOfWork.SaveChangesAsync();

            drzava = Mapper.Map<Drzava, DrzavaResource>(novaDrzava);

            return Ok(novaDrzava);
        }
        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjene drzave iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrzava([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var drzava = await UnitOfWork.Drzave.GetAsync(id);
            if (drzava == null)
            {
                return NotFound();
            }

            var novaDrzava = Mapper.Map<Drzava, DrzavaResource>(drzava);
            UnitOfWork.Drzave.Remove(drzava);
            await UnitOfWork.SaveChangesAsync();

            return Ok(novaDrzava);
        }
    }
}