using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using DomUcenikaSvilajnac.Common.Models;
using System.Threading.Tasks;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using DomUcenikaSvilajnac.ModelResources;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Ucenik klasu, tj ucenike.
    /// Pogledati IRepository i klasu Ucenik radi dodatnih pojasnjenja.
    /// </summary>
    public interface IUcenikRepository:IRepository<Ucenik>
    {
        Task<IEnumerable<UcenikResource>> podaciUcenika();
        Task<UcenikResource> podaciUcenikaById(int id);
        Task<PostUcenikaResource> mapiranjeZaPostUcenika(PostUcenikaResource ucenik);
        Task<UcenikResource> mapiranjeZaDeleteUcenika(UcenikResource ucenik);
        Task<PutUcenikaResource> mapiranjeZaPutUcenika(int id);
        float formulaZaRangiranje(int idUcenika);
    }
}
