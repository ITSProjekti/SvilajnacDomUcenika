using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Mesta")]
    public class Mesto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Naziv { get; set; }
    }
}
