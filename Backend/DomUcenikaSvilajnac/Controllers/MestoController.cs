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
    [Route("api/Mesta")]
    public class MestoController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase PolController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public MestoController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih polova koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<MestoResource>> GetMesta()
        {
            var listaMesta = await UnitOfWork.Mesta.GetAllAsync();
            return Mapper.Map<List<Mesto>, List<MestoResource>>(listaMesta.ToList());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMestoById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mesto = await UnitOfWork.Mesta.GetAsync(id);
            var novoMesto = Mapper.Map<Mesto, MestoResource>(mesto);
            if (mesto == null)
            {
                return NotFound();
            }

            return Ok(novoMesto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMesto([FromRoute] int id, [FromBody] MestoResource mesto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staroMesto = await UnitOfWork.Mesta.GetAsync(id);
            if (id != staroMesto.Id)
            {
                return BadRequest();
            }
            if (staroMesto == null)
                return NotFound();


            mesto.Id = id;
            Mapper.Map<MestoResource, Mesto>(mesto, staroMesto);
            await UnitOfWork.SaveChangesAsync();

            var novoMesto = await UnitOfWork.Mesta.GetAsync(id);
            Mapper.Map<Mesto, MestoResource>(novoMesto);
            return Ok(mesto);
        }

        [HttpPost]
        public async Task<IActionResult> PostMesto([FromBody] MestoResource mesto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var novoMesto = Mapper.Map<MestoResource, Mesto>(mesto);

            UnitOfWork.Mesta.Add(novoMesto);
            await UnitOfWork.SaveChangesAsync();

            mesto = Mapper.Map<Mesto, MestoResource>(novoMesto);

            return Ok(novoMesto);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMesto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mesto = await UnitOfWork.Mesta.GetAsync(id);
            if (mesto == null)
            {
                return NotFound();
            }

            var novoMesto = Mapper.Map<Mesto, MestoResource>(mesto);
            UnitOfWork.Mesta.Remove(mesto);
            await UnitOfWork.SaveChangesAsync();

            return Ok(novoMesto);
        }
    }
}