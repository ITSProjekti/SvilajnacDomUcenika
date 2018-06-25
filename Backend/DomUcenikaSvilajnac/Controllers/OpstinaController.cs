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
        public OpstinaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<OpstinaResource>> GetOpstine()
        {
            var listaOpstina = await UnitOfWork.Opstine.GetAllAsync();
            return Mapper.Map<List<Opstina>, List<OpstinaResource>>(listaOpstina.ToList());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetMestoById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var opstina = await UnitOfWork.Opstine.GetAsync(id);
            var opstinaNova = Mapper.Map<Opstina, OpstinaResource>(opstina);
            if (opstina == null)
            {
                return NotFound();
            }

            return Ok(opstinaNova);
        }
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

            return Ok(novaOpstina);
        }
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