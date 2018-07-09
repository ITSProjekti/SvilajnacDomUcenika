using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    [Table("SrednjeSkole")]
    public class UpisanaSkola
    {
        public int Id { get; set; }
        public string NazivSrednjeSkole { get; set; }
        public int OpstinaId { get; set; }
        public Opstina Opstina { get; set; }

        ICollection<Ucenik> Ucenici { get; set; }

        public UpisanaSkola()
        {
            Ucenici = new Collection<Ucenik>();
        }
        // ICollection<Ucenik> Ucenici { get; set; }



    }
}
