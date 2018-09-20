using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Drzava klasu, tj. drzave.
    /// Pogledati IRepository i klasu Drzava radi dodatnih pojasnjenja.
    /// </summary>
    public interface IDrzavaRepository : IRepository<Drzava>
    {
    }
}
