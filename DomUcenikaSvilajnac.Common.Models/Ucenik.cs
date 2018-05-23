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
        [StringLength(50, ErrorMessage = "Prekoracena maksimalna duzina za Ime.")]
        public string Ime { get; set; }
        [StringLength(50, ErrorMessage = "Prekoracena maksimalna duzina za Prezime.")]
        public string Prezime { get; set; }
        [MaxLength(13),MinLength(13)]
        public string JMBG { get; set; }

    }
}
