using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    public class Kazna
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        ICollection<Ucenik> Ucenici { get; set; }

        public Kazna()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
