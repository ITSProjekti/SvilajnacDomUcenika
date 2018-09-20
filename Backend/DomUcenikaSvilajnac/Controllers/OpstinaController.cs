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
    [Route("api/Opstine")]
    public class OpstinaController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Inicijalizacija instance klase OpstinaController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public OpstinaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih opstina koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<OpstinaResource>> GetOpstine()
        {

            var listaOpstina = await UnitOfWork.Opstine.podaciSaOpstinama();
            var mapiranjeUcenikaMesta = Mapper.Map<List<OpstinaResource>, List<Opstina>>(listaOpstina.ToList());
            return Mapper.Map<List<Opstina>, List<OpstinaResource>>(mapiranjeUcenikaMesta.ToList());

        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekoj opstini na osnovu prosledjenog Id-a 
        /// i vraca podatke o opstini koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOpstina([FromRoute] int id, [FromBody] OpstinaResource opstina)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staraOpstina = await UnitOfWork.Opstine.GetAsync(id);
            if (id != staraOpstina.Id)
            {
                return BadRequest();
            }
            if (staraOpstina == null)
                return NotFound();


            opstina.Id = id;
            Mapper.Map<OpstinaResource, Opstina>(opstina, staraOpstina);
            await UnitOfWork.SaveChangesAsync();

            var novaOpstina = await UnitOfWork.Opstine.GetAsync(id);
            Mapper.Map<Opstina, OpstinaResource>(novaOpstina);
            return Ok(opstina);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. nove opstine.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostOpstina([FromBody] OpstinaResource opstina)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var novaOpstina = Mapper.Map<OpstinaResource, Opstina>(opstina);

            UnitOfWork.Opstine.Add(novaOpstina);
            await UnitOfWork.SaveChangesAsync();

            opstina = Mapper.Map<Opstina, OpstinaResource>(novaOpstina);

            return Ok(opstina);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjene opstine iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpstina([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var opstina = await UnitOfWork.Opstine.GetAsync(id);
            if (opstina == null)
            {
                return NotFound();
            }
            var novaOpstina = Mapper.Map<Opstina, OpstinaResource>(opstina);
            UnitOfWork.Opstine.Remove(opstina);
            await UnitOfWork.SaveChangesAsync();

            return Ok(novaOpstina);
        }
    }
}