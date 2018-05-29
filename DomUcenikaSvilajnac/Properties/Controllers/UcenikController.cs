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
    [Produces("application/json")]
    [Route("api/Ucenik")]
    public class UcenikController : Controller
    {
      

        public IMapper _mapper { get; }
        public IUnitOfWork UnitOfWork { get; }
        public UcenikContext Context { get; }

        
        public UcenikController(IMapper mapper,IUnitOfWork unitOfWork)
        {
          
            _mapper = mapper;
            UnitOfWork =unitOfWork ;
        }

        // GET: api/Ucenik
        [HttpGet]
        public async Task<IEnumerable<UcenikResource>> GetUceniks()
        {
         
            var listaUcenika = await UnitOfWork.Ucenici.GetAllAsync();
            
            return _mapper.Map<List<Ucenik>, List<UcenikResource>>(listaUcenika.ToList()   );
        }

        // GET: api/Ucenik/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUcenik([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ucenik = await UnitOfWork.Ucenici.GetAsync(id);
            var ucenikNovi=_mapper.Map<Ucenik, UcenikResource>(ucenik);
            if (ucenik == null)
            {
                return NotFound();
            }

            return Ok(ucenikNovi);
        }

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
            _mapper.Map<UcenikResource, Ucenik>(ucenik,stariUcenik);
            await UnitOfWork.SaveChangesAsync();

            var noviUcenik = await UnitOfWork.Ucenici.GetAsync(id);
            _mapper.Map<Ucenik, UcenikResource>(noviUcenik);
            return Ok(ucenik);
        }

        // POST: api/Ucenik
        [HttpPost]
        public async Task<IActionResult> PostUcenik([FromBody] UcenikResource ucenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           var noviUcenik= _mapper.Map<UcenikResource, Ucenik>(ucenik);
            UnitOfWork.Ucenici.Add(noviUcenik);
            await UnitOfWork.SaveChangesAsync();

            ucenik= _mapper.Map<Ucenik,UcenikResource>(noviUcenik);
            return Ok(ucenik);
        }

        // DELETE: api/Ucenik/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUcenik([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var ucenik = await UnitOfWork.Ucenici.GetAsync(id);
            if (ucenik == null)
            {
                return NotFound();
            }
            var noviUcenik = _mapper.Map< Ucenik, UcenikResource>(ucenik);
            UnitOfWork.Ucenici.Remove(ucenik);
            await UnitOfWork.SaveChangesAsync();

            return Ok(noviUcenik);
        }

        private bool UcenikExists(int id)
        {
            return (UnitOfWork.Ucenici.Get(id)==null);
        }
    }
}