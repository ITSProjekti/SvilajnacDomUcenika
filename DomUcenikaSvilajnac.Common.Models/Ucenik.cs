using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Ucenici")]
    public class Ucenik
    {
       
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Ime { get; set; }
        [Required]
        [StringLength(50)]
        public string Prezime { get; set; }
        [Required]
        [MaxLength(13),MinLength(13)]
        public string JMBG { get; set; }

        [Required]
        public string Pol { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime DatumRodjenja { get; set; }
    }
}
