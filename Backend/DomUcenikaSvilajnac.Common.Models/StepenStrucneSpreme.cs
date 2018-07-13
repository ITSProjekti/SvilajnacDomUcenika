using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("StepeniStrucneSpreme")]
    public class StepenStrucneSpreme
    {
        public int Id { get; set; }
        public string Stepen { get; set; }
        public string Opis { get; set; }
    }
}
