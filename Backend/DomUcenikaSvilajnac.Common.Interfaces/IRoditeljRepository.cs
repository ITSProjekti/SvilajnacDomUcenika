using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Roditelj klasu, tj. roditelje.
    /// Pogledati IRepository i klasu Roditelj radi dodatnih pojasnjenja.
    /// </summary>
    public interface IRoditeljRepository : IRepository<Roditelj>
    {
        Task<IEnumerable<RoditeljResource>> spremaRoditelja();
        Task<IEnumerable<RoditeljResource>> roditeljiUcenika(int UcenikId);
        Task<IEnumerable<PutRoditeljaResource>> roditeljiUcenikaZaPut(int UcenikId);
    }
}
