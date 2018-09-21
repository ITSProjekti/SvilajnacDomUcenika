using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Razred klasu, tj. razrede.
    /// Pogledati IRepository i klasu Razred radi dodatnih pojasnjenja.
    /// </summary>
    public interface IRazredRepository : IRepository<Razred>
    {
    }
}
