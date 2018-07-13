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
    [Route("api/Roditelji")]
    public class RoditeljController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase RoditeljController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public RoditeljController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }
        /// <summary>
        /// Vraca listu svih roditlja koji se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<RoditeljResource>> GetRoditelji()
        {

            var listaRoditelja = await UnitOfWork.Roditelji.GetAllAsync();

            List<RoditeljResource> listaResurs = new List<RoditeljResource>();
            var roditelj = Mapper.Map<List<Roditelj>, List<RoditeljResource>>(listaRoditelja.ToList(), listaResurs);

            return roditelj;   // Mapper.Map<List<Roditelj>, List<RoditeljResource>>(listaRoditelja.ToList());
        }
        /// <summary>
        /// Vraca dva reda iz tabele, tj. roditelje na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoditeljById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            List<Roditelj> roditelji = new List<Roditelj>();
            if (id % 2 != 0)
            {
                var majka = await UnitOfWork.Roditelji.GetAsync(id-1);
                var otac = await UnitOfWork.Roditelji.GetAsync(id);
                roditelji.Add(majka);
                roditelji.Add(otac);
            }
            else
            {
                var majka = await UnitOfWork.Roditelji.GetAsync(id);
                var otac = await UnitOfWork.Roditelji.GetAsync(id + 1);
                roditelji.Add(majka);
                roditelji.Add(otac);
            }

            var roditelj = Mapper.Map<List<Roditelj>, RoditeljResource>(roditelji);

            //var roditeljNovi = Mapper.Map<Roditelj, RoditeljResource>(roditelj);
            if (roditelji == null)
            {
                return NotFound();
            }

            return Ok(roditelj);
        }
        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom roditlju na osnovu prosledjenog Id-a 
        /// i vraca podatke o roditelju koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoditelj([FromRoute] int id, [FromBody] RoditeljResource roditelj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariRoditelj = await UnitOfWork.Roditelji.GetAsync(id);
            if (id != stariRoditelj.Id)
            {
                return BadRequest();
            }
            if (stariRoditelj == null)
                return NotFound();


            roditelj.Id = id;
            Mapper.Map<RoditeljResource, Roditelj>(roditelj, stariRoditelj);
            await UnitOfWork.SaveChangesAsync();

            var noviRoditelj = await UnitOfWork.Roditelji.GetAsync(id);
            Mapper.Map<Roditelj, RoditeljResource>(noviRoditelj);
            return Ok(roditelj);
        }
        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog roditlja.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostRoditelj([FromBody] RoditeljResource roditelj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var majka = new Roditelj() { Ime = roditelj.ImeMajke, Prezime = roditelj.PrezimeMajke };
            var otac = Mapper.Map<RoditeljResource, Roditelj>(roditelj);
            List<Roditelj> roditelji = new List<Roditelj>();
            roditelji.Add(majka);
            roditelji.Add(otac);
            UnitOfWork.Roditelji.AddRange(roditelji);

            await UnitOfWork.SaveChangesAsync();
            
            roditelj  = Mapper.Map<List<Roditelj>, RoditeljResource>(roditelji);
            
            return Ok(roditelj);
        }
        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog roditelja iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoditelj([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roditelj = await UnitOfWork.Roditelji.GetAsync(id);
            if (roditelj == null)
            {
                return NotFound();
            }

            var noviRoditelj = Mapper.Map<Roditelj, RoditeljResource>(roditelj);
            UnitOfWork.Roditelji.Remove(roditelj);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviRoditelj);
        }
    }
}