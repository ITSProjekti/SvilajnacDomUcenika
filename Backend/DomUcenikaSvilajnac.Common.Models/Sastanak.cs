using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{ 
    [Table("Sastanci")]
    public class Sastanak
    {
    public int Id { get; set; }
    public DateTime DatumOdrzavanja { get; set; }
    }
}
