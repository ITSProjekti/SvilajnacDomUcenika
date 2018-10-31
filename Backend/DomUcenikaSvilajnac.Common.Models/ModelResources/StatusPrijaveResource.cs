using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{

    /// <summary>
    /// Sluzi za podakte koji ce se slati na front, u slucaju da neki podatak nije potrebno poslati na front, smanjuje se broj property-a u odnosu na 
    /// klasu StatusPrijave.
    /// </summary>
    public class StatusPrijaveResource
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
