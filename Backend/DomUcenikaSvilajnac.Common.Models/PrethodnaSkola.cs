using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("PrethodneSkole")]
    public class PrethodnaSkola
    {
        public int PrethodnaSkolaId { get; set; }
        public string NazivPrethodneSkole { get; set; }
    }
}
