using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Sluzi za podakte koji ce se slati na front, u slucaju da neki podatak nije potrebno poslati na front, smanjuje se broj property-a u odnosu na 
    /// klasu Statistika.
    /// </summary>
    public class StatistikaResource
    {
        public int Id { get; set; }
        public float UspehVaspitneGrupe { get; set; }
        public string Posecenost { get; set; }
        public int BodoviPohvalaGrupa { get; set; }
        public VaspitnaGrupaStatistikeResource VaspitnaGrupa { get; set; }
    }
}
