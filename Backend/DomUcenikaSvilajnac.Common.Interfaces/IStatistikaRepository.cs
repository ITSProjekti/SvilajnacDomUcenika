using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Statistika klasu, tj. statistike.
    /// Pogledati IRepository i klasu Statistika radi dodatnih pojasnjenja.
    /// </summary>
    public interface IStatistikaRepository : IRepository<Statistika>
    {
        Task<IEnumerable<StatistikaResource>> podaciStatistike();
    }
}
