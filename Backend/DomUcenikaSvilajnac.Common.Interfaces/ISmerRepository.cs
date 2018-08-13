using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Smer klasu, tj. smerove.
    /// Pogledati IRepository i klasu Smer radi dodatnih pojasnjenja.
    /// </summary>
    public interface ISmerRepository : IRepository<Smer>
    {
    }
}
