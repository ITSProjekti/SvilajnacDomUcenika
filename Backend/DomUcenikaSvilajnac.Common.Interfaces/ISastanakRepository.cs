using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Sastanak klasu, tj. sastanke.
    /// Pogledati IRepository i klasu Sastanak radi dodatnih pojasnjenja.
    /// </summary>
    public interface ISastanakRepository:IRepository<Sastanak>
    {
        Task<IEnumerable<SastanakResource>> sviSastanci();
        Task<SastanakResource> sastanakById(int id);
        Task<SastanakResource> mapiranjeZaPostSastanka(SastanakResource sastanak);
        Task<SastanakResource> mapiranjeZaPutSastanka(int id);
        Task<SastanakResource> mapiranjeZaDeleteSastanka(SastanakResource sastanak);
    }
}
