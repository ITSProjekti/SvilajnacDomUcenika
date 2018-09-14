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
    [Route("api/VaspitneGrupe")]
    public class VaspitnaGrupaController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase PolController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public VaspitnaGrupaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IEnumerable<VaspitnaGrupaResource>> GetVaspitneGrupe()
        {
            var listaVaspitnihGrupa = await UnitOfWork.VaspitneGrupe.GetAllAsync();
            return Mapper.Map<List<VaspitnaGrupa>, List<VaspitnaGrupaResource>>(listaVaspitnihGrupa.ToList());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVaspitneGrupeById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vaspitnaGrupa = await UnitOfWork.VaspitneGrupe.GetAsync(id);
            var novaVaspitnaGrupa = Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(vaspitnaGrupa);
            if (vaspitnaGrupa == null)
            {
                return NotFound();
            }

            return Ok(novaVaspitnaGrupa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutVaspitneGrupe([FromRoute] int id, [FromBody] VaspitnaGrupaResource vaspitnaGrupa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staraVaspitnaGrupa = await UnitOfWork.VaspitneGrupe.GetAsync(id);
            if (id != staraVaspitnaGrupa.Id)
            {
                return BadRequest();
            }
            if (staraVaspitnaGrupa == null)
                return NotFound();


            vaspitnaGrupa.Id = id;
            Mapper.Map<VaspitnaGrupaResource, VaspitnaGrupa>(vaspitnaGrupa, staraVaspitnaGrupa);
            await UnitOfWork.SaveChangesAsync();

            var novaVaspitnaGrupa = await UnitOfWork.VaspitneGrupe.GetAsync(id);
            Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(novaVaspitnaGrupa);
            return Ok(vaspitnaGrupa);
        }
        [HttpPost]
        public async Task<IActionResult> PostVaspitnaGrupa([FromBody] VaspitnaGrupaResource vaspitnaGrupa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var novaVaspitnaGrupa = Mapper.Map<VaspitnaGrupaResource, VaspitnaGrupa>(vaspitnaGrupa);

            UnitOfWork.VaspitneGrupe.Add(novaVaspitnaGrupa);
            await UnitOfWork.SaveChangesAsync();

            vaspitnaGrupa = Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(novaVaspitnaGrupa);

            return Ok(novaVaspitnaGrupa);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVaspitneGrupe([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vaspitnaGrupa = await UnitOfWork.VaspitneGrupe.GetAsync(id);
            if (vaspitnaGrupa == null)
            {
                return NotFound();
            }

            var novaVaspitnaGrupa = Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(vaspitnaGrupa);
            UnitOfWork.VaspitneGrupe.Remove(vaspitnaGrupa);
            await UnitOfWork.SaveChangesAsync();

            return Ok(novaVaspitnaGrupa);
        }
    }
}