using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa UpisanaSkola, pravi tabelu "SrednjeSkole" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("SrednjeSkole")]
    public class UpisanaSkola
    {
        public int Id { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string NazivSrednjeSkole { get; set; }
        public int OpstinaId { get; set; }
        public Opstina Opstina { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public UpisanaSkola()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
