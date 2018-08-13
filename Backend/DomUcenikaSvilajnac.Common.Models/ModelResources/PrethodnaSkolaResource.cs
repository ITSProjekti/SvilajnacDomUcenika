using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Sluzi za podakte koji ce se slati na front, u slucaju da neki podatak nije potrebno poslati na front, smanjuje se broj property-a u odnosu na 
    /// klasu PrethodnaSkola.
    /// </summary>
    public class PrethodnaSkolaResource
    {
        public int Id { get; set; }
        public string NazivPrethodneSkole { get; set; }
        public int OpstinaId { get; set; }
    }
}
