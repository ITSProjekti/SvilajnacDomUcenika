using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("PostanskiBrojevi")]
    public class PostanskiBroj
    {
        public int Id { get; set; }
        public string Broj { get; set; }
        public int OpstinaId { get; set; }
        public Opstina Opstina { get; set; }
    }
}
