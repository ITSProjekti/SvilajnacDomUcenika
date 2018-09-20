using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za Opstina klasu, tj. opstine.
    /// Pogledati IRepository i klasu Opstina radi dodatnih pojasnjenja.
    /// </summary>
    public interface IOpstinaRepository :IRepository<Opstina>
    {
        Task<IEnumerable<OpstinaResource>> podaciSaOpstinama();
    }
}
