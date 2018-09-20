using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa TipPorodice, pravi tabelu "TipoviPorodice" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("TipoviPorodice")]
    public class TipPorodice
    {
        public int Id { get; set; }
        public string NazivTipaPorodice { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public TipPorodice()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
