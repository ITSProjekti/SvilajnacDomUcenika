using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
using DomUcenikaSvilajnac.ModelResources;
using Microsoft.AspNetCore.Mvc;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// IUnitOfWork interfejs za klasu UnitOfWork koja implementira navedene SaveChanges metode.
    /// Za uvid u implementaciju prikazanih metoda pogledati /DAL/RepoPattern/UnitOfWork
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IUcenikRepository Ucenici { get; }
       
        IOpstinaRepository Opstine { get; }

        IDrzavaRepository Drzave { get; }
        IPolRepository Polovi { get; }
        ITelefonRepository Telefoni { get; }
        IPostanskiBrojRepository Brojevi { get; }
        IPrethodnaSkolaRepository PrethodneSkole { get; }

        IUpisanaSkola UpisaneSkole { get; }
        IMestoRepository    Mesta { get; }

        ISmerRepository Smerovi { get; }
        IRazredRpository Razredi { get; }
        IRoditeljRepository Roditelji { get; }
        IStepenStrucneSpremeRepository Stepeni { get; }
        ITipPorodiceRepository TipoviPorodice { get; }
        IStarateljRepository Staratelji { get; }
        IPohvalaRepository Pohvale { get; }
        IVaspitnaGrupaRepository VaspitneGrupe { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<IEnumerable<UcenikResource>> podaciUcenika();

        Task<UcenikResource> podaciUcenikaById(int id);
        Task<PostUcenikaResource> mapiranjeZaPostUcenika(PostUcenikaResource ucenik);
 
        void deleteTelefon(Telefon telefon);

        Task<IEnumerable<OpstinaResource>> podaciSaOpstinama();
        Task<IEnumerable<RoditeljResource>> roditeljiUcenika(int UcenikId);
        Task<IEnumerable<DeleteRoditeljaResource>> brisanjeRoditelja(int UcenikId);

        Task<IEnumerable<RoditeljResource>> spremaRoditelja();

        Task<UcenikResource> mapiranjeZaDeleteUcenika(UcenikResource ucenik);
        Task<PutUcenikaResource> mapiranjeZaPutUcenika(int id);
        Task<IEnumerable<PutRoditeljaResource>> roditeljiUcenikaZaPut(int UcenikId);

        //metoda za test
        Task<Staratelj> selektIdStarateljaUcenika(int UcenikId);

    }
}