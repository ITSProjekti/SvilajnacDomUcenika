using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    public class Pohvala
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        ICollection<Ucenik> Ucenici { get; set; }

        public Pohvala()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
