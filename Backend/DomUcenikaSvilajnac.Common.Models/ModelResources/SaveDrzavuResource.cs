using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    public class SaveDrzavuResource
    {
        public int Id { get; set; }
        public string NazivDrzave { get; set; }

        public ICollection<int> Kontinenti { get; set; }
        public SaveDrzavuResource()
        {
            Kontinenti = new Collection<int>();
        }
    }
}
