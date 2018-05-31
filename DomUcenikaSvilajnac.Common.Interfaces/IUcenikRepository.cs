using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using DomUcenikaSvilajnac.Common.Models;
namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Ucenik klasu, tj ucenike.
    /// Pogledati IRepository i klasu Ucenik radi dodatnih pojasnjenja.
    /// </summary>
    public interface IUcenikRepository:IRepository<Ucenik>
    {
     
    }
}
