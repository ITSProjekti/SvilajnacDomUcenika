using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za TipPorodice klasu, tj. tipove porodice.
    /// Pogledati IRepository i klasu TipPorodice radi dodatnih pojasnjenja.
    /// </summary>
    public interface ITipPorodiceRepository : IRepository<TipPorodice>
    {
    }
}
