using DomUcenikaSvilajnac.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.Context
{
    /// <summary>
    /// UcenikContext klasa koja nasledjuje DbContext koji predstavlja sesiju sa bazom podataka, 
    /// sluzi za upite tj querije i cuvanje podataka u bazi.
    /// Kombinacija Unit of work i Repository paterna
    /// </summary>
    public class UcenikContext:DbContext
    {
        /// <summary>
        /// Sluzi kao komunkacija sa bazom podataka.
        /// </summary>
        public DbSet<Ucenik> Uceniks { get; set; }
        public DbSet<Opstina> Opstine { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Pol> Polovi { get; set; }
        public DbSet<Telefon> Telefoni { get; set; }
        /// <summary>
        /// Inicijalizuje se instaca UcenikContext klase.
        /// </summary>
        public UcenikContext(DbContextOptions<UcenikContext> options):base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
          
        //}
    }
}
