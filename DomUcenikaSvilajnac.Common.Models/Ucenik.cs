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
        public string Ime { get; set; }
    }
}
