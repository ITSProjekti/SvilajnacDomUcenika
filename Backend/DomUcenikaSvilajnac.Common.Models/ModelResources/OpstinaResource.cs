using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Sluzi za podakte koji ce se slati na front, u slucaju da neki podatak nije potrebno poslati na front, smanjuje se broj property-a u odnosu na 
    /// klasu Opstina.
    /// </summary>
    public class OpstinaResource
    {
        public int Id { get; set; }

        public string NazivOpstine { get; set; }

       public  ICollection<int> PostanskiBrojevi { get; set; }
       public ICollection<int> SrednjeSkole { get; set; }
      public  ICollection<int> OsnovneSkole { get; set; }

    }
}
