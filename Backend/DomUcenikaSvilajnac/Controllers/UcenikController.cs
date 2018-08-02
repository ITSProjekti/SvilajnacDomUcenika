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
using DomUcenikaSvilajnac.Common.Models.ModelResources;

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
        /// Vraca jedan red iz tabele, tj. jednog ucenika na osnovu prosledjenog Id-a.
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
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom uceniku na osnovu prosledjenog Id-a 
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
            int pom = stariUcenik.TelefonId;

            TelefonResource telefon = new TelefonResource { Id = pom, Mobilni = ucenik.Telefon.Mobilni, Kucni = ucenik.Telefon.Kucni };
            var stariTelefon = await UnitOfWork.Telefoni.GetAsync(telefon.Id);


            var noviTelefon = _mapper.Map<TelefonResource, Telefon>(telefon, stariTelefon);

            UnitOfWork.deleteTelefon(noviTelefon);

            //   await UnitOfWork.SaveChangesAsync();


            if (id != stariUcenik.Id)
            {
                return BadRequest();
            }
            if (stariUcenik == null)
                return NotFound();

            ucenik.Id = id;

            var novi = _mapper.Map<UcenikResource, Ucenik>(ucenik, stariUcenik);
            novi.TelefonId = pom;
            novi.Opstina = null;
            novi.DrzavaRodjenja = null;
            novi.OpstinaPrebivalista = null;
            novi.Pol = null;
            novi.PostanskiBroj = null;
            novi.MestoPrebivalista = null;
            novi.MestoRodjenja = null;
            novi.MestoZavrseneSkole = null;
            novi.PrethodnaSkola = null;
            novi.UpisanaSkola = null;
            novi.Smer = null;
            novi.Razred = null;
            //  novi.Telefon = null;

            UnitOfWork.SaveChanges();


            var noviUcenik = await UnitOfWork.mestaUcenikaById(id);
            return Ok(noviUcenik);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog ucenika.
        /// </summary>
        // POST: api/Ucenik
        [HttpPost]
        public async Task<IActionResult> PostUcenik([FromBody] UcenikResource ucenik)
        {
            //instanciranje objekta za telefon radi cuvanja u tabelu telefon
            // Telefon mobilni = new Telefon { Mobilni = ucenik.Telefon.Mobilni, Kucni = ucenik.Telefon.Kucni };
            List<Roditelj> roditelji = new List<Roditelj>();
            Roditelj otac = new Roditelj()
            {
                Ime = ucenik.Roditelji.ImeOca,
                Prezime = ucenik.Roditelji.PrezimeOca,
                BrojTelefona = ucenik.Roditelji.BrojTelefonaOca,
                StepenObrazovanjaId = ucenik.Roditelji.StrucnaSpremaOcaId,
            };
           
            Roditelj majka = new Roditelj()
            {
                Ime = ucenik.Roditelji.ImeMajke,
                Prezime = ucenik.Roditelji.PrezimeMajke,
                BrojTelefona = ucenik.Roditelji.BrojTelefonaMajke,
                StepenObrazovanjaId = ucenik.Roditelji.StrucnaSpremaMajkeId,

            };
           



            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var noviUcenik = _mapper.Map<UcenikResource, Ucenik>(ucenik);
            noviUcenik.VremeUpisa = DateTime.Now;

            noviUcenik.Opstina = null;
            noviUcenik.DrzavaRodjenja = null;
            noviUcenik.OpstinaPrebivalista = null;
            noviUcenik.Pol = null;
            noviUcenik.PostanskiBroj = null;
            noviUcenik.MestoPrebivalista = null;
            noviUcenik.MestoRodjenja = null;
            noviUcenik.MestoZavrseneSkole = null;
            noviUcenik.PrethodnaSkola = null;
            noviUcenik.UpisanaSkola = null;
            noviUcenik.Smer = null;
            noviUcenik.Razred = null;

           
            //kada se cuvaju prvo kolone ne ide null
            // noviUcenik.Telefon = null;

            //cuvanje u bazi
            UnitOfWork.Ucenici.Add(noviUcenik);
            await UnitOfWork.SaveChangesAsync();


            otac.UcenikId = noviUcenik.Id;
            majka.UcenikId = noviUcenik.Id;

            roditelji.Add(otac);
            roditelji.Add(majka);

            UnitOfWork.Roditelji.AddRange(roditelji);
            UnitOfWork.SaveChanges();




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

            var telefonUcenika = await UnitOfWork.Telefoni.GetAsync(ucenik.Telefon.Id);

            //brisanje u bazi
            UnitOfWork.Ucenici.Remove(ucenik);
            UnitOfWork.Telefoni.Remove(telefonUcenika);
            await UnitOfWork.SaveChangesAsync();

            return Ok(mapiranUcenik);
        }       
    }
}