using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using AutoMapper;
using DomUcenikaSvilajnac.ModelResources;
using DomUcenikaSvilajnac.Common.Interfaces;

namespace DomUcenikaSvilajnac.Controllers
{
    /// <summary>
    /// Klasa UcenikController koja implementira CRUD metode.
    /// </summary>
    [Produces("application/json")]
    [Route("api/Ucenik")]
    public class UcenikController : Controller
    {
        public IMapper _mapper { get; }
        public IUnitOfWork UnitOfWork { get; }

        public UcenikContext context;

        /// <summary>
        /// Inicijalizacija instance klase UcenikController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public UcenikController(IMapper mapper,IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            UnitOfWork =unitOfWork ;
        }

        /// <summary>
        /// Vraca listu sviih ucenika, koji se trenutno nalaze u bazi.
        /// </summary>
        /// GET: api/Ucenik        
        [HttpGet]
        public async Task<IEnumerable<UcenikResource>> GetUceniks()
        {
           // var listaUcenika = await UnitOfWork.Ucenici.GetAllAsync(); -- promenljiva koja prima listu svih ucenika
            var listaUcenikaMesta = await UnitOfWork.mestaUcenika();

            var mapiranjeUcenikaMesta = _mapper.Map<List<UcenikResource>, List<Ucenik>>(listaUcenikaMesta.ToList());

            return _mapper.Map<List<Ucenik>, List<UcenikResource>>(mapiranjeUcenikaMesta.ToList());
        }


        /// <summary>
        /// Vraca jedan red iz tabele, tj jednog ucenika na osnovu prosledjenog Id-a.
        /// </summary>
        // GET: api/Ucenik/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUcenik([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mapiranUcenik = UnitOfWork.mestaUcenikaById(id);


            var ucenik = await UnitOfWork.Ucenici.GetAsync(id);
            var ucenikNovi = _mapper.Map<Ucenik, UcenikResource>(ucenik);
            if (ucenik == null)
            {
                return NotFound();
            }

            return Ok(ucenikNovi);
        }


        /// <summary>
        /// Metoda za update, menja podate u nekom redu u tabeli, tj.o nekom uceniku na osnovu prosledjenog Id-a 
        /// i vraca podatke o uceniku koji su namenjeni za front.
        /// </summary>
        // PUT: api/Ucenik/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUcenik([FromRoute] int id, [FromBody] UcenikResource ucenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var stariUcenik = await UnitOfWork.Ucenici.GetAsync(id);
            if (id != stariUcenik.Id)
            {
                return BadRequest();
            }
            if (stariUcenik == null)
                return NotFound();



            ucenik.Id = id;

            var novi = _mapper.Map<UcenikResource, Ucenik>(ucenik, stariUcenik);
            novi.MestoId = ucenik.Mesto.Id;
            novi.Mesto = null;
            await UnitOfWork.SaveChangesAsync();

            var noviUcenik = await UnitOfWork.Ucenici.GetAsync(id);
            _mapper.Map<Ucenik, UcenikResource>(noviUcenik);
            return Ok(ucenik);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog ucenika.
        /// </summary>
        // POST: api/Ucenik
        [HttpPost]
        public async Task<IActionResult> PostUcenik([FromBody] UcenikResource ucenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviUcenik = _mapper.Map<UcenikResource, Ucenik>(ucenik);
            noviUcenik.Mesto = null;
            noviUcenik.Opstina = null;
            
            //cuvanje u bazi
            UnitOfWork.Ucenici.Add(noviUcenik);
            await UnitOfWork.SaveChangesAsync();

            ucenik = _mapper.Map<Ucenik, UcenikResource>(noviUcenik);
            var mapiranUcenik = await UnitOfWork.mapiranje(ucenik);

            return Ok(mapiranUcenik);
        }

        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog ucenika iz tabele.
        /// </summary>
        // DELETE: api/Ucenik/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUcenik([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ucenik = await UnitOfWork.Ucenici.GetAsync(id);

            
            var noviUcenik = _mapper.Map<Ucenik, UcenikResource>(ucenik);
            var mapiranUcenik = await UnitOfWork.mapiranje(noviUcenik);

            if (ucenik == null)
            {
                return NotFound();
            }
           
            //brisanje u bazi
            UnitOfWork.Ucenici.Remove(ucenik);
            await UnitOfWork.SaveChangesAsync();

            

          

            return Ok(mapiranUcenik);
        }

        /// <summary>
        /// Proveravanje da li odredjeni ucenik postoji, koristi se za CRUD operacije.
        /// </summary>
        private bool UcenikExists(int id)
        {
            return (UnitOfWork.Ucenici.Get(id) == null);
        }
    }
}