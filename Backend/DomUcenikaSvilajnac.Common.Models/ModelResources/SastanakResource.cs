using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Sluzi za podakte koji ce se slati na front, u slucaju da neki podatak nije potrebno poslati na front, smanjuje se broj property-a u odnosu na 
    /// klasu Sastanak.
    /// </summary>
    public class SastanakResource
    {
        public int Id { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public int BrojPrisutnihUcenika { get; set; }
        public int UkupanBrojPrisutnihUcenika { get; set; }
        public GetSastanakVasptinaGrupaResource VaspitnaGrupa { get; set; }

        public string OpisDnevnogRada { get; set; }

        public string OdlukeDoneseneNaSastanku { get; set; }

        public string ZakljucciSastanka { get; set; }
    }
}
