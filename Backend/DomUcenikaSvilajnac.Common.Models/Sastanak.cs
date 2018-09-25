using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Sastanak, pravi tabelu "Sastanci" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Sastanci")]
    public class Sastanak
    {
        public int Id { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public int BrojPrisutnihUcenika { get; set; }
        public int UkupanBrojPrisutnihUcenika { get; set; }
        public int VaspitnaGrupaId { get; set; }
        public VaspitnaGrupa VaspitnaGrupa { get; set; }

        public string OpisDnevnogRada { get; set; }
        public string OdlukeDoneseneNaSastanku { get; set; }
        public string ZakljucciSastanka { get; set; }


    }
}
