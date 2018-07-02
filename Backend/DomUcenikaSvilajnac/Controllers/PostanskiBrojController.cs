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
    [Route("api/PostanskiBrojevi")]
    public class PostanskiBrojController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Inicijalizacija instance klase PostanskiBrojController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public PostanskiBrojController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu sviih postanskih brojeva, koji se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<PostanskiBrojResource>> GetPostanskiBrojevi()
        {
            var listaBrojeva = await UnitOfWork.Brojevi.GetAllAsync();
            return Mapper.Map<List<PostanskiBroj>, List<PostanskiBrojResource>>(listaBrojeva.ToList());
        }

        /// <summary>
        /// Vraca jedan red iz tabele, tj. jedan postanski broj na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPostanskiBrojById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var postanskiBroj = await UnitOfWork.Brojevi.GetAsync(id);
            var noviPostanskiBroj = Mapper.Map<PostanskiBroj, PostanskiBrojResource>(postanskiBroj);
            if (postanskiBroj == null)
            {
                return NotFound();
            }

            return Ok(noviPostanskiBroj);
        }

        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom postanskom broju na osnovu prosledjenog Id-a 
        /// i vraca podatke o postanskom broju koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostanskiBroj([FromRoute] int id, [FromBody] PostanskiBrojResource postanskiBroj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariPosatanskiBroj = await UnitOfWork.Brojevi.GetAsync(id);
            if (id != stariPosatanskiBroj.Id)
            {
                return BadRequest();
            }
            if (stariPosatanskiBroj == null)
                return NotFound();


            postanskiBroj.Id = id;
            Mapper.Map<PostanskiBrojResource, PostanskiBroj>(postanskiBroj, stariPosatanskiBroj);
            
            await UnitOfWork.SaveChangesAsync();

            var noviPostanskiBroj = await UnitOfWork.Brojevi.GetAsync(id);
            Mapper.Map<PostanskiBroj, PostanskiBrojResource>(noviPostanskiBroj);
            return Ok(postanskiBroj);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog postanskog broja.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostPostanskiBroj([FromBody] PostanskiBrojResource postanskiBroj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviPostasnkiBroj = Mapper.Map<PostanskiBrojResource, PostanskiBroj>(postanskiBroj);

            UnitOfWork.Brojevi.Add(noviPostasnkiBroj);
            await UnitOfWork.SaveChangesAsync();

            postanskiBroj = Mapper.Map<PostanskiBroj, PostanskiBrojResource>(noviPostasnkiBroj);

            return Ok(noviPostasnkiBroj);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog postanskog broja iz tabele.
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePostanskiBroj([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var postanskiBroj = await UnitOfWork.Brojevi.GetAsync(id);
            if (postanskiBroj == null)
            {
                return NotFound();
            }
            var noviPostanskiBroj = Mapper.Map<PostanskiBroj, PostanskiBrojResource>(postanskiBroj);
            UnitOfWork.Brojevi.Remove(postanskiBroj);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviPostanskiBroj);
        }
    }
}