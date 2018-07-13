using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa StepenStrucneSpreme, pravi tabelu "StepeniStrucneSpreme" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("StepeniStrucneSpreme")]
    public class StepenStrucneSpreme
    {
        public int Id { get; set; }
        public string Stepen { get; set; }
        public string Opis { get; set; }
    }
}
