using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Sluzi za podakte koji ce se slati na front, u slucaju da neki podatak nije potrebno poslati na front, smanjuje se broj property-a u odnosu na 
    /// klasu Kazna.
    /// </summary>
    public class KaznaResource
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int BodoviKazne { get; set; }
        public int UcenikId { get; set; }
        public DateTime VremeUpisa { get; set; }
    }
}
