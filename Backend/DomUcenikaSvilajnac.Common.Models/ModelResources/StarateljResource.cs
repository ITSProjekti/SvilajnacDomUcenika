using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Sluzi za podakte koji ce se slati na front, u slucaju da neki podatak nije potrebno poslati na front, smanjuje se broj property-a u odnosu na 
    /// klasu Staratelj.
    /// </summary>
    public class StarateljResource
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int UcenikId { get; set; }

    }
}
