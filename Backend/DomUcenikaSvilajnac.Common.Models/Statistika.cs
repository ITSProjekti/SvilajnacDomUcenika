using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Statistika, pravi tabelu "Statistike" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Statistike")]
    public class Statistika
    {     
        public int Id { get; set; }
        public float UspehVaspitneGrupe { get; set; }
        public string Posecenost { get; set; }

        public int BodoviPohvalaGrupa { get; set; }

        public int VaspitnaGrupaId { get; set; }
        public VaspitnaGrupa VaspitnaGrupa { get; set; }

    }
}
