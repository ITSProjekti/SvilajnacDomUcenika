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
        public UcenikController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Vraca listu sviih ucenika, koji se trenutno nalaze u bazi.
        /// </summary>
        /// GET: api/Ucenik        
        [HttpGet]
        public async Task<IEnumerable<UcenikResource>> GetUcenika()
        {
            // var listaUcenika = await UnitOfWork.Ucenici.GetAllAsync(); -- promenljiva koja prima listu svih ucenika
            var listaUcenikaMesta = await UnitOfWork.podaciUcenika();
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

            var mapiranUcenik = UnitOfWork.podaciUcenikaById(id);


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
        public async Task<IActionResult> PutUcenik([FromRoute] int id, [FromBody] PutUcenikaResource ucenik)
        {
            PutRoditeljaResource roditeljResurs = new PutRoditeljaResource()
            {
                Id = ucenik.Roditelji.Id,
                IdMajke = ucenik.Roditelji.IdMajke,
                ImeMajke = ucenik.Roditelji.ImeMajke,
                PrezimeMajke = ucenik.Roditelji.PrezimeMajke,
                ImeOca = ucenik.Roditelji.ImeOca,
                PrezimeOca = ucenik.Roditelji.PrezimeOca,
                BrojTelefonaMajke = ucenik.Roditelji.BrojTelefonaMajke,
                BrojTelefonaOca = ucenik.Roditelji.BrojTelefonaOca,
                StrucnaSpremaMajkeId = ucenik.Roditelji.StrucnaSpremaMajkeId,
                StrucnaSpremaOcaId = ucenik.Roditelji.StrucnaSpremaOcaId,
                UcenikId = ucenik.Roditelji.UcenikId
            };
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var stariUcenik = await UnitOfWork.Ucenici.GetAsync(id);
            int pom = stariUcenik.TelefonId;
            TelefonResource telefon = new TelefonResource { Id = pom, Mobilni = ucenik.Telefon.Mobilni, Kucni = ucenik.Telefon.Kucni };
            var stariTelefon = await UnitOfWork.Telefoni.GetAsync(telefon.Id);

            //koriscenje klase telefon kontrolera kako bih pozvao metodu put za taj objekat
            TelefonController telefonKontroler = new TelefonController(_mapper, UnitOfWork);
            await telefonKontroler.PutTelefon(telefon.Id, telefon);

            if (id != stariUcenik.Id)
            {
                return BadRequest();
            }
            if (stariUcenik == null)
                return NotFound();

            ucenik.Id = id;

            var novi = _mapper.Map<PutUcenikaResource, Ucenik>(ucenik, stariUcenik);
            novi.TelefonId = pom;


            await UnitOfWork.SaveChangesAsync();

            //kreiranje instance kontrolera roditelja
            RoditeljController roditeljKontroler = new RoditeljController(_mapper, UnitOfWork);
            await roditeljKontroler.PutRoditelj(novi.Id, roditeljResurs);



            var noviUcenik = await UnitOfWork.mapiranjeZaPutUcenika(id);
            return Ok(noviUcenik);
        }

        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog ucenika.
        /// </summary>
        // POST: api/Ucenik
        [HttpPost]
        public async Task<IActionResult> PostUcenik([FromBody] PostUcenikaResource ucenik)
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
            var noviUcenik = _mapper.Map<PostUcenikaResource, Ucenik>(ucenik);
            noviUcenik.VremeUpisa = DateTime.Now;
            ucenik.Staratelj.UcenikId = noviUcenik.Id;


            //kada se cuvaju prvo kolone ne ide null
            // noviUcenik.Telefon = null;

            //cuvanje u bazi
            UnitOfWork.Ucenici.Add(noviUcenik);
            await UnitOfWork.SaveChangesAsync();

            //provera da li je tip porodice koji zahteva da ucenik ima staratelja, ako jeste pozvace se staratelj kontroler i njegova post metoda
            if (noviUcenik.TipPorodiceId == 4 || noviUcenik.TipPorodiceId == 5)
            {
                StarateljController starateljKontroler = new StarateljController(_mapper, UnitOfWork);
                ucenik.Staratelj.UcenikId = noviUcenik.Id;
                await starateljKontroler.PostStaratelj(ucenik.Staratelj);
            }
            
            
            otac.UcenikId = noviUcenik.Id;
            majka.UcenikId = noviUcenik.Id;

            roditelji.Add(otac);
            roditelji.Add(majka);

            UnitOfWork.Roditelji.AddRange(roditelji);
            UnitOfWork.SaveChanges();

            //proverava da li je tip porodice koji zahteva da ucenik ima staratelja
            if (noviUcenik.TipPorodiceId != 4 || noviUcenik.TipPorodiceId != 5)
                noviUcenik.Staratelji.Add(new Staratelj { Id = 0, Ime = "", Prezime = "", UcenikId = 0 });
            ucenik = _mapper.Map<Ucenik, PostUcenikaResource>(noviUcenik);

            var mapiranUcenik = await UnitOfWork.mapiranjeZaPostUcenika(ucenik);

           


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
            var mapiranUcenik = await UnitOfWork.mapiranjeZaDeleteUcenika(noviUcenik);

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