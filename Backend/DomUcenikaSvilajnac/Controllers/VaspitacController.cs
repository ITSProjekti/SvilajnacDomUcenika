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
    [Route("api/Vaspitaci")]
    public class VaspitacController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase PolController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public VaspitacController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih polova koje se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<VaspitacResource>> GetVaspitace()
        {
            var listaVaspitaca = await UnitOfWork.Vaspitaci.GetAllAsync();
            return Mapper.Map<List<Vaspitac>, List<VaspitacResource>>(listaVaspitaca.ToList());


        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVaspitacById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vaspitac = await UnitOfWork.Vaspitaci.GetAsync(id);
            var noviVaspitac = Mapper.Map<Vaspitac, VaspitacResource>(vaspitac);
            if (vaspitac == null)
            {
                return NotFound();
            }

            return Ok(noviVaspitac);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVaspitac([FromRoute] int id, [FromBody] VaspitacResource vaspitac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariVaspitac = await UnitOfWork.Vaspitaci.GetAsync(id);
            if (id != stariVaspitac.Id)
            {
                return BadRequest();
            }
            if (stariVaspitac == null)
                return NotFound();


            vaspitac.Id = id;
            Mapper.Map<VaspitacResource, Vaspitac>(vaspitac, stariVaspitac);
            await UnitOfWork.SaveChangesAsync();

            var noviVaspitac = await UnitOfWork.Vaspitaci.GetAsync(id);
            Mapper.Map<Vaspitac, VaspitacResource>(noviVaspitac);
            return Ok(vaspitac);
        }

        [HttpPost]
        public async Task<IActionResult> PostVaspitac([FromBody] VaspitacResource vaspitac)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviVaspitac = Mapper.Map<VaspitacResource, Vaspitac>(vaspitac);

            UnitOfWork.Vaspitaci.Add(noviVaspitac);
            await UnitOfWork.SaveChangesAsync();

            vaspitac = Mapper.Map<Vaspitac, VaspitacResource>(noviVaspitac);

            return Ok(vaspitac);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVaspitac([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var vaspitac = await UnitOfWork.Vaspitaci.GetAsync(id);
            if (vaspitac == null)
            {
                return NotFound();
            }

            var noviVaspitac = Mapper.Map<Vaspitac, VaspitacResource>(vaspitac);
            UnitOfWork.Vaspitaci.Remove(vaspitac);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviVaspitac);
        }


    }
}