using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Pohvala klasu, tj. pohvale.
    /// Pogledati IRepository i klasu Pohvala radi dodatnih pojasnjenja.
    /// </summary>
    public interface IPohvalaRepository : IRepository<Pohvala>
    {
        Task<IEnumerable<PohvalaResource>> pohvaleUcenikaById(int UcenikId);
    }
}
