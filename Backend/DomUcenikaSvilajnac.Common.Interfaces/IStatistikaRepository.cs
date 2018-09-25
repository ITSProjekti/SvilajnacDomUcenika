using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Statistika klasu, tj. statistike.
    /// Pogledati IRepository i klasu Statistika radi dodatnih pojasnjenja.
    /// </summary>
    public interface IStatistikaRepository : IRepository<Statistika>
    {
    }
}
