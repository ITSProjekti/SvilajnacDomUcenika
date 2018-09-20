using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Kazna klasu, tj. kazne.
    /// Pogledati IRepository i klasu Kazna radi dodatnih pojasnjenja.
    /// </summary>
    public interface IKaznaRepository : IRepository<Kazna>
    {
        Task<IEnumerable<KaznaResource>> kazneUcenikaById(int UcenikId);
    }
}
