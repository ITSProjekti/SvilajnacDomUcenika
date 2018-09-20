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
            return await UnitOfWork.vaspitneGrupe();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVaspitneGrupeById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapiranaGrupa = UnitOfWork.vaspitneGrupeById(id);

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

            var novaVaspitnaGrupa = await UnitOfWork.mapiranjeZaPutGrupe(id);
            return Ok(novaVaspitnaGrupa);
        }
        [HttpPost]
        public async Task<IActionResult> PostVaspitnaGrupa([FromBody] VaspitnaGrupaResource vaspitnaGrupa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            vaspitnaGrupa.Vaspitac = new VaspitacResource() { Id = 1 };
            var novaVaspitnaGrupa = Mapper.Map<VaspitnaGrupaResource, VaspitnaGrupa>(vaspitnaGrupa);

            UnitOfWork.VaspitneGrupe.Add(novaVaspitnaGrupa);
            await UnitOfWork.SaveChangesAsync();

            vaspitnaGrupa = Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(novaVaspitnaGrupa);

            var mapiranaGrupa = await UnitOfWork.mapiranjeZaPostVaspitneGrupe(vaspitnaGrupa);
            return Ok(mapiranaGrupa);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVaspitneGrupe([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           await UnitOfWork.updateBrojaUcenikaUVaspitnojGrupi();

            var vaspitnaGrupa = await UnitOfWork.VaspitneGrupe.GetAsync(id);
            
            if (vaspitnaGrupa == null)
            {
                return NotFound();
            }

            var novaVaspitnaGrupa = Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(vaspitnaGrupa);
            var mapiranaGrupa = await UnitOfWork.mapiranjeZaDeleteGrupe(novaVaspitnaGrupa);
            UnitOfWork.VaspitneGrupe.Remove(vaspitnaGrupa);
            await UnitOfWork.SaveChangesAsync();

            return Ok(mapiranaGrupa);
        }
    }
}