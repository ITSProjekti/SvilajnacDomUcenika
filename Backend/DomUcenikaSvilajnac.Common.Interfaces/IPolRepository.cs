using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Pol klasu, tj. polove.
    /// Pogledati IRepository i klasu Pol radi dodatnih pojasnjenja.
    /// </summary>
    public interface IPolRepository : IRepository<Pol>
    {
    }
}
