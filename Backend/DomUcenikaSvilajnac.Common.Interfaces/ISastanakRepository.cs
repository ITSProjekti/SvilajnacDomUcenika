using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Sastanak klasu, tj. sastanke.
    /// Pogledati IRepository i klasu Sastanak radi dodatnih pojasnjenja.
    /// </summary>
    public interface ISastanakRepository:IRepository<Sastanak>
    {
    }
}
