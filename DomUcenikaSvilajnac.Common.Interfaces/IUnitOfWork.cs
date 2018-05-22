using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUcenikRepository Ucenici { get; }
        int SaveChanges();
    }
}