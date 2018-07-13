using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Pol, pravi tabelu "Polovi" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Polovi")]
    public class Pol
    {
        public int Id { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string NazivPola { get; set; }
        ICollection<Ucenik> Ucenici { get; set; }

        public Pol()
        {
            Ucenici = new Collection<Ucenik>();
        }

    }
}
