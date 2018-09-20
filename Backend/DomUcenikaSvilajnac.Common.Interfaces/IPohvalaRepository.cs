using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Pohvala klasu, tj. pohvale.
    /// Pogledati IRepository i klasu Pohvala radi dodatnih pojasnjenja.
    /// </summary>
    public interface IPohvalaRepository : IRepository<Pohvala>
    {
    }
}
