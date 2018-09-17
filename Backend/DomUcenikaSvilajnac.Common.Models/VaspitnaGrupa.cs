using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    public class VaspitnaGrupa
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int VaspitacId { get; set; }
        public Vaspitac Vaspitac { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public VaspitnaGrupa()
        {
            Ucenici = new Collection<Ucenik>();
        }
    }
}
