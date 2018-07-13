using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za StepenStrucneSpreme klasu, tj. stepene strucne spreme.
    /// Pogledati IRepository i klasu StepenStrucneSpreme radi dodatnih pojasnjenja.
    /// </summary>
    public interface IStepenStrucneSpremeRepository : IRepository<StepenStrucneSpreme>
    {
    }
}
