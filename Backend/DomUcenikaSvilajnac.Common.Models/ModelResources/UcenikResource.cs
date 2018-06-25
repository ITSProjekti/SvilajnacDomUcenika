using DomUcenikaSvilajnac.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.ModelResources
{
    /// <summary>
    /// Sluzi za podakte koji ce se slati na fron, u slucaju da neki podatak nije potrebno poslati na front, smanjuje se broj property-a u odnosu na 
    /// klasu Ucenik.
    /// </summary>
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

        public Mesto Mesto { get; set; }
        public Opstina Opstina { get; set; }
        
     


    }
}
