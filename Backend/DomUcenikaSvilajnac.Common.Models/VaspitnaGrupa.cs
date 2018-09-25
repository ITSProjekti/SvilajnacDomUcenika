using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa VaspitnaGrupa, pravi tabelu "VaspitneGrupe" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("VaspitneGrupe")]
    public class VaspitnaGrupa
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int VaspitacId { get; set; }
        public Vaspitac Vaspitac { get; set; }

        public int BrojUcenika { get; set; }
        ICollection<Ucenik> Ucenici { get; set; }
        ICollection<Sastanak> Sastanci { get; set; }
        ICollection<Statistika> Statistike { get; set; }

        public VaspitnaGrupa()
        {
            Ucenici = new Collection<Ucenik>();
            Sastanci = new Collection<Sastanak>();
            Statistike = new Collection<Statistika>();
        }
    }
}
