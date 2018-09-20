using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{ 
    [Table("Sastanci")]
    public class Sastanak
    {
        public int Id { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public int BrojPrisutnihUcenika { get; set; }
        public int UkupanBrojPrisutnihUcenika { get; set; }
        public int VaspitnaGrupaId { get; set; }
        public VaspitnaGrupa VaspitnaGrupa { get; set; }

    }
}
