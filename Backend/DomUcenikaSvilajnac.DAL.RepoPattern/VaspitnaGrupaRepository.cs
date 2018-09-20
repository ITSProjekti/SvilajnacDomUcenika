using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using DomUcenikaSvilajnac.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public class VaspitnaGrupaRepository : Repository<VaspitnaGrupa>, IVaspitnaGrupaRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }

        public IVaspitnaGrupaRepository VaspitneGrupe { get; set; }
        /// </summary>
        public VaspitnaGrupaRepository(UcenikContext context,IMapper mapper) : base(context)
        {
            _context = context;
            Mapper = mapper;

        }
      
        /// <summary>
        /// Get the context.
        /// </summary>
        public UcenikContext context
        {
            get { return context as UcenikContext; }
        }

        public async Task<IEnumerable<VaspitnaGrupaResource>> vaspitneGrupe()
        {
            var podaciVaspitaca = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .ToListAsync();

            return Mapper.Map<List<VaspitnaGrupa>, List<VaspitnaGrupaResource>>(podaciVaspitaca);
        }
        public async Task<VaspitnaGrupaResource> vaspitneGrupeById(int id)
        {
            var vaspitnaGrupaById = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(vaspitnaGrupaById);
        }
        public async Task<VaspitnaGrupaResource> mapiranjeZaPostVaspitneGrupe(VaspitnaGrupaResource vaspitnaGrupa)
        {
            var podaciGrupe = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .SingleOrDefaultAsync(x => x.Id == vaspitnaGrupa.Id);

            return Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(podaciGrupe);
        }

        public async Task<VaspitnaGrupaResource> mapiranjeZaPutGrupe(int id)
        {
            var podaciGrupe = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(podaciGrupe);
        }

        public async Task<VaspitnaGrupaResource> mapiranjeZaDeleteGrupe(VaspitnaGrupaResource vaspitnaGrupa)
        {
            var podaciGrupe = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .SingleOrDefaultAsync(x => x.Id == vaspitnaGrupa.Id);

            return Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(podaciGrupe);
        }
        public async void updateUcenikaVaspitnaGrupaId(int IdObrisaneVaspitneGrupe)
        {


            var listaUcenikaIsteVaspitneGrupe = await _context.Uceniks.
            FromSql(
            $"select *  from dbo.Ucenici  where VaspitnaGrupaId = {IdObrisaneVaspitneGrupe}"
            )
            .ToListAsync();

            listaUcenikaIsteVaspitneGrupe.ForEach(a =>
            {
                a.VaspitnaGrupaId = 1;
            });

            _context.UpdateRange(listaUcenikaIsteVaspitneGrupe);
        }
         public async Task<VaspitnaGrupa> updateBrojaUcenikaUVaspitnojGrupi()
        {
       
            //promenljiva u kojoj se smesta lista svih vaspitnih grupa
            var listaVaspitnihGrupa = await _context.VaspitneGrupe.
            FromSql(
                $"select *  from dbo.VaspitneGrupe"
                )
                .ToListAsync();

            //nizovi u kojima cemo da smestimo listu id-eva i broj ucenika za datu vaspitnu grupu
            int[] NizIdVaspitnihGrupa = new int[listaVaspitnihGrupa.Count];
            int[] nizBrojaUcenika = new int[listaVaspitnihGrupa.Count];
            int i = 0;

            //petlja za uzimanje id-a svih vaspitnih grupa
            foreach (var item in listaVaspitnihGrupa)
                NizIdVaspitnihGrupa[i++] = item.Id;
            i = 0;

             /*  petlja u kojoj se u svakoj iteraciji broje ucenici za datu vaspitnu grupu
             i update se broj ucenika svake vaspitne grupe*/
            foreach (var item in listaVaspitnihGrupa)
            {
                var brojUcenika = await _context.Uceniks.CountAsync(n => n.VaspitnaGrupaId == NizIdVaspitnihGrupa[i]);
                item.BrojUcenika = brojUcenika;
                i++;
            }

            //smestanje vaspitne grupe koja je izabrana kako bismo promenili vrednost broja Ucenika u toj tabeli
            var vaspitnaGrupa = await _context.VaspitneGrupe.FirstOrDefaultAsync(n => n.Id == 1);
            _context.VaspitneGrupe.UpdateRange(listaVaspitnihGrupa);
            await _context.SaveChangesAsync();
            return vaspitnaGrupa;
        }

    }
}
