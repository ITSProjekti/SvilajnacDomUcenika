using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Interfejs za metode koje su samo za VaspitnaGrupa klasu, tj. vaspitne grupe.
    /// Pogledati IRepository i klasu VaspitnaGrupa radi dodatnih pojasnjenja.
    /// </summary>
    public interface IVaspitnaGrupaRepository : IRepository<VaspitnaGrupa>
    {
        Task<IEnumerable<VaspitnaGrupaResource>> vaspitneGrupe();
        Task<VaspitnaGrupaResource> vaspitneGrupeById(int id);
        Task<VaspitnaGrupaResource> mapiranjeZaPostVaspitneGrupe(VaspitnaGrupaResource vaspitna);
        Task<VaspitnaGrupaResource> mapiranjeZaPutGrupe(int id);
        Task<VaspitnaGrupaResource> mapiranjeZaDeleteGrupe(VaspitnaGrupaResource vaspitnaGrupa);
        void updateUcenikaVaspitnaGrupaId(int IdObrisaneVaspitneGrupe);
        Task<VaspitnaGrupa> updateBrojaUcenikaUVaspitnojGrupi();
    }
}
