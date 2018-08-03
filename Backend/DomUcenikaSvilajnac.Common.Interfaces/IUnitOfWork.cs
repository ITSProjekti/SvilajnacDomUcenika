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

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<IEnumerable<UcenikResource>> mestaUcenika();

        Task<UcenikResource> mestaUcenikaById(int id);
        Task<PostUcenikaResource> mapiranje(PostUcenikaResource ucenik);
     //   Task<PostPostUcenikaResource> mapiranjeZaPostUcenika(PostPostUcenikaResource ucenik);
        void deleteTelefon(Telefon telefon);

        Task<IEnumerable<OpstinaResource>> brojeviOpstine();
        Task<IEnumerable<RoditeljResource>> roditeljiUcenika(int UcenikId);
        Task<IEnumerable<DeleteRoditeljaResource>> brisanjeRoditelja(int UcenikId);

        Task<IEnumerable<RoditeljResource>> spremaRoditelja();

        Task<UcenikResource> mapiranjeZaDeleteUcenika(UcenikResource ucenik);


    }
}