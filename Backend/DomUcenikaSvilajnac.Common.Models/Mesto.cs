using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("Mesta")]
    public class Mesto
    {
        public int Id { get; set; }
        public string NazivMesta { get; set; }
        //Za spajanje dva puta na ucenika


        [InverseProperty("MestoRodjenja")]
        ICollection<Ucenik> MestaUcenika { get; set; }

        [InverseProperty("MestoPrebivalista")]
        ICollection<Ucenik> MestaPrebivalistaUcenika { get; set; }
    }
}
