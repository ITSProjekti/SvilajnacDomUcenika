using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.ModelResources
{
    public class UcenikResource
    {

           public int Id { get; set; }
        public string Ime { get; set; }
        
        public string Prezime { get; set; }

        public string JMBG { get; set; }

        public string Pol { get; set; }

     //    public DateTime DatumRodjenja { get; set; }
        public int Dan { get; set; }
        public int Mesec { get; set; }

        public int Godina { get; set; }
    }
}
