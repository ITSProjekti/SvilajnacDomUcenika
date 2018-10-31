using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za StatusPrijave klasu, tj. statuse prijave.
    /// Pogledati IRepository i klasu StatusPrijave radi dodatnih pojasnjenja.
    /// </summary>
    public interface IStatusPrijaveRepository : IRepository<StatusPrijave>
    {

    }
}
