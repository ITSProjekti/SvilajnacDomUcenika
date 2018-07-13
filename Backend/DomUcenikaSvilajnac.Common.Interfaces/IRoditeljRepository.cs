using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Roditelj klasu, tj. roditelje.
    /// Pogledati IRepository i klasu Roditelj radi dodatnih pojasnjenja.
    /// </summary>
    public interface IRoditeljRepository : IRepository<Roditelj>
    {
    }
}
