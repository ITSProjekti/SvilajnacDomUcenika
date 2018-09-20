using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Vaspitac klasu, tj. vaspitace.
    /// Pogledati IRepository i klasu Vaspitac radi dodatnih pojasnjenja.
    /// </summary>
    public interface IVaspitacRepository : IRepository<Vaspitac>
    {
    }
}
