using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("SrednjeSkole")]
    public class UpisanaSkola
    {
        public int Id { get; set; }
        public string NazivSrednjeSkole { get; set; }
    }
}
