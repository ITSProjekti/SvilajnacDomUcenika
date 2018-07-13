using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Telefon klasu, tj. telefone.
    /// Pogledati IRepository i klasu Telefon radi dodatnih pojasnjenja.
    /// </summary>
    public interface ITelefonRepository: IRepository<Telefon>
    {
    }
}
