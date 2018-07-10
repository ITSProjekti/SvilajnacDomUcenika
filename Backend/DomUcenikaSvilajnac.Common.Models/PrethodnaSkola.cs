using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("OsnovneSkole")]
    public class PrethodnaSkola
    {
        public int Id { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string NazivPrethodneSkole { get; set; }

        public int OpstinaId { get; set; }

        public Opstina Opstina { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public PrethodnaSkola()
        {
            Ucenici = new Collection<Ucenik>();
        }

    }
}
