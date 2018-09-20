using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Kazna klasu, tj. kazne.
    /// Pogledati IRepository i klasu Kazna radi dodatnih pojasnjenja.
    /// </summary>
    public interface IKaznaRepository : IRepository<Kazna>
    {
    }
}
