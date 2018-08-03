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
    [Route("api/Roditelji")]
    public class RoditeljController : Controller
    {
        public IMapper Mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// Inicijalizacija instance klase RoditeljController i deklarisanje mappera i unitofwork-a.
        /// </summary>
        public RoditeljController(IMapper mapper, IUnitOfWork unitOfWork)
        {
            Mapper = mapper;
            UnitOfWork = unitOfWork;
        }
        /// <summary>
        /// Vraca listu svih roditlja koji se trenutno nalaze u bazi.
        /// </summary>
        [HttpGet]
        public async Task<IEnumerable<RoditeljResource>> GetRoditelji()
        {

            return await UnitOfWork.spremaRoditelja();
        }
        /// <summary>
        /// Vraca dva reda iz tabele, tj. roditelje na osnovu prosledjenog Id-a.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IEnumerable<RoditeljResource>> GetRoditeljById([FromRoute] int id)
        {

            return  await UnitOfWork.roditeljiUcenika(id);
        }
        /// <summary>
        /// Metoda za update, menja podatke u nekom redu u tabeli, tj. o nekom roditlju na osnovu prosledjenog Id-a 
        /// i vraca podatke o roditelju koji su namenjeni za front.
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoditelj([FromRoute] int id, [FromBody] PutRoditeljaResource roditelj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            int[] nizId = new int[2];

              var listaRoditelja = await UnitOfWork.roditeljiUcenikaZaPut(id);
            foreach (var item in listaRoditelja)
            {
                nizId[0] = item.IdMajke;
                nizId[1] = item.Id;
                break;
            }


            var stariOtac = await UnitOfWork.Roditelji.GetAsync(nizId[1]);
            var staraMajka = await UnitOfWork.Roditelji.GetAsync(nizId[0]);
           



            //if (id != stariRoditelj.Id)
            //{
            //    return BadRequest();
            //}
            //if (stariRoditelj == null)
            // return NotFound();


            
            roditelj.Id = nizId[1];
            roditelj.IdMajke = nizId[0];
            



            var djesi = Mapper.Map<PutRoditeljaResource, MajkaResource>(roditelj);
            

            djesi.IdMajke = nizId[0];
            djesi.Id = nizId[1];


            Mapper.Map<PutRoditeljaResource, Roditelj>(roditelj, stariOtac);
            staraMajka.Id = nizId[0];
            Mapper.Map<MajkaResource, Roditelj>(djesi, staraMajka);
            await UnitOfWork.SaveChangesAsync();



            //   UnitOfWork.SaveChanges();


            var noviRoditelj = await UnitOfWork.Roditelji.GetAsync(id);
            Mapper.Map<Roditelj, PutRoditeljaResource>(noviRoditelj);
            return Ok(roditelj);
        }
        /// <summary>
        /// Dodavanje novog reda u tabeli, tj. novog roditlja.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostRoditelj([FromBody] PostRoditeljaResource roditelj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var majka = new Roditelj() { Ime = roditelj.ImeMajke, Prezime = roditelj.PrezimeMajke, UcenikId = roditelj.UcenikId, BrojTelefona =roditelj.BrojTelefonaMajke, StepenObrazovanjaId = roditelj.StrucnaSpremaMajkeId};
            var otac = Mapper.Map<PostRoditeljaResource, Roditelj>(roditelj);
            List<Roditelj> roditelji = new List<Roditelj>();
            roditelji.Add(majka);
            roditelji.Add(otac);
            UnitOfWork.Roditelji.AddRange(roditelji);

            await UnitOfWork.SaveChangesAsync();
            
            roditelj  = Mapper.Map<List<Roditelj>, PostRoditeljaResource>(roditelji);
            
            return Ok(roditelj);
        }
        /// <summary>
        /// Brisanje jednog reda iz tabele na osnvou prosledjenog Id-a, tj. brisanje odredjenog roditelja iz tabele.
        /// </summary>
        [HttpDelete("{UcenikId}")]
        public async Task<IActionResult> DeleteRoditelj([FromRoute] int UcenikId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            } 
           var noviRoditelj= await UnitOfWork.brisanjeRoditelja(UcenikId);


           return Ok(noviRoditelj);
        }
    }
}