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
    [Route("api/Sastanci")]
    public class SastanakController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase SastanakController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public SastanakController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu svih Sastanaka koji se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<SastanakResource>> GetSastanci()
        {
            return await UnitOfWork.Sastanci.sviSastanci();
        }

        /// <summary>
        /// Vraca listu svih sastanaka koji se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSastanakById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapiranSastanak = await UnitOfWork.Sastanci.sastanakById(id);

            var sastanak = await UnitOfWork.Sastanci.GetAsync(id);
            var noviSastanak = Mapper.Map<Sastanak, SastanakResource>(sastanak);
            if (sastanak == null)
            {
                return NotFound();
            }

            return Ok(noviSastanak);
        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom sastanku na osnovu prosledjenog Id-a 
        /// i vraca podatke o sastanku koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSastanak([FromRoute] int id, [FromBody] SastanakResource sastanak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariSastanak = await UnitOfWork.Sastanci.GetAsync(id);
            if (id != stariSastanak.Id)
            {
                return BadRequest();
            }
            if (stariSastanak == null)
                return NotFound();


            sastanak.Id = id;
            sastanak.DatumOdrzavanja = DateTime.Now;
            Mapper.Map<SastanakResource, Sastanak>(sastanak, stariSastanak);
            await UnitOfWork.SaveChangesAsync();

            var noviSastanak = await UnitOfWork.Sastanci.mapiranjeZaPutSastanka(id);
            
            return Ok(noviSastanak);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog sastanka.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostSastanak([FromBody] SastanakResource sastanak)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviSastanak = Mapper.Map<SastanakResource, Sastanak>(sastanak);

            noviSastanak.UkupanBrojPrisutnihUcenika =  UnitOfWork.Sastanci.brojUcenikaNaSastanku(noviSastanak.VaspitnaGrupaId);

            noviSastanak.DatumOdrzavanja = DateTime.Now;

            UnitOfWork.Sastanci.Add(noviSastanak);
            await UnitOfWork.SaveChangesAsync();
            //metoda koja ce da pokupi broj ucenika u toj vaspitnoj grupi
            //sastanak.VaspitnaGrupa.Id

            sastanak = Mapper.Map<Sastanak, SastanakResource>(noviSastanak);
            var mapiranSastanak = await UnitOfWork.Sastanci.mapiranjeZaPostSastanka(sastanak);


          

            return Ok(mapiranSastanak);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog sastanka iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSastanak([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sastanak = await UnitOfWork.Sastanci.GetAsync(id);
            if (sastanak == null)
            {
                return NotFound();
            }
            
            var noviSastanak = Mapper.Map<Sastanak, SastanakResource>(sastanak);
            var mapiranSastanak = await UnitOfWork.Sastanci.mapiranjeZaDeleteSastanka(noviSastanak);
            UnitOfWork.Sastanci.Remove(sastanak);
            await UnitOfWork.SaveChangesAsync();

            return Ok(mapiranSastanak);
        }
    }
}