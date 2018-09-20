using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Staratelj klasu, tj. staratelje.
    /// Pogledati IRepository i klasu Staratelj radi dodatnih pojasnjenja.
    /// </summary>
    public interface IStarateljRepository : IRepository<Staratelj>
    {

    }
}
