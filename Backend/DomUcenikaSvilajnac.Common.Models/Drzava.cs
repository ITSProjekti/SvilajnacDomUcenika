using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Drzave")]
    public class Drzava
    {
        public int Id { get; set; }
        public string NazivDrzave { get; set; }
    }
}
