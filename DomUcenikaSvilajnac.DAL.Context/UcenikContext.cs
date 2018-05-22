using DomUcenikaSvilajnac.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.Context
{
    public class UcenikContext:DbContext
    {

        public UcenikContext(DbContextOptions<UcenikContext> options):base(options)
        {

        }
        public DbSet<Ucenik> Uceniks { get; set; }
    }
}
