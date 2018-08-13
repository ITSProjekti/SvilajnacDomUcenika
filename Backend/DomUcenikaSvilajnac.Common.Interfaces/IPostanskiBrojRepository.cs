using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za PostanskiBroj klasu, tj. postanske brojeve.
    /// Pogledati IRepository i klasu PostanskiBroj radi dodatnih pojasnjenja.
    /// </summary>
    public interface IPostanskiBrojRepository : IRepository<PostanskiBroj>
    {
    }
}
