using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUcenikRepository Ucenici { get; }
        int SaveChanges();
    }
}