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
        /// Inicijalizacija instance klase VaspitnaGrupaController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public VaspitnaGrupaController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih vaspitnih grupa koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<VaspitnaGrupaResource>> GetVaspitneGrupe()
        {
            return await UnitOfWork.VaspitneGrupe.vaspitneGrupe();
        }

        /// <summary>
        /// Vraca jedan red iz tabele, tj. vaspitnu grupu na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVaspitneGrupeById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapiranaGrupa = UnitOfWork.VaspitneGrupe.vaspitneGrupeById(id);

            var vaspitnaGrupa = await UnitOfWork.VaspitneGrupe.GetAsync(id);
            var novaVaspitnaGrupa = Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(vaspitnaGrupa);
            if (vaspitnaGrupa == null)
            {
                return NotFound();
            }

            return Ok(novaVaspitnaGrupa);
        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekoj vaspitnoj grupi na osnovu prosledjenog Id-a 
        /// i vraca podatke o vaspitnoj grupi koji su namenjeni za front.
        /// </summary>
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

            var novaVaspitnaGrupa = await UnitOfWork.VaspitneGrupe.mapiranjeZaPutGrupe(id);
            await UnitOfWork.VaspitneGrupe.updateBrojaUcenikaUVaspitnojGrupi();
            return Ok(novaVaspitnaGrupa);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. nove vaspitne grupe.
        /// </summary>
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

            var mapiranaGrupa = await UnitOfWork.VaspitneGrupe.mapiranjeZaPostVaspitneGrupe(vaspitnaGrupa);
            await UnitOfWork.VaspitneGrupe.updateBrojaUcenikaUVaspitnojGrupi();
            return Ok(mapiranaGrupa);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjene vaspitne grupe iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVaspitneGrupe([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

             UnitOfWork.VaspitneGrupe.updateUcenikaVaspitnaGrupaId(id);
             UnitOfWork.VaspitneGrupe.updateSastanka(id);

            var vaspitnaGrupa = await UnitOfWork.VaspitneGrupe.GetAsync(id);
            
            if (vaspitnaGrupa == null)
            {
                return NotFound();
            }

            var novaVaspitnaGrupa = Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(vaspitnaGrupa);
            var mapiranaGrupa = await UnitOfWork.VaspitneGrupe.mapiranjeZaDeleteGrupe(novaVaspitnaGrupa);
            UnitOfWork.VaspitneGrupe.Remove(vaspitnaGrupa);
            await UnitOfWork.SaveChangesAsync();
            await UnitOfWork.VaspitneGrupe.updateBrojaUcenikaUVaspitnojGrupi();
            return Ok(mapiranaGrupa);
        }
    }
}