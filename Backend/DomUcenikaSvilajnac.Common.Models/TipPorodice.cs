using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
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
