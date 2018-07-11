using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Smerovi")]
    public class Smer
    {
        public int Id { get; set; }
        public string NazivSmera { get; set; }

    }
}
