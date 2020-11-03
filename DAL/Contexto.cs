using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SegundoParcial.Entidades;

namespace SegundoParcial.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Tipos> Tipos { get; set; }
        public DbSet<TareasDetalle> TareasDetalle { get; set; }
        public DbSet<Proyectos> Proyectos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Data/Databse.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Tipos>().HasData(new Tipos { TipoId = 1, TipoTarea = "Analisis" });
           modelBuilder.Entity<Tipos>().HasData(new Tipos { TipoId = 2, TipoTarea = "Diseño"});
           modelBuilder.Entity<Tipos>().HasData(new Tipos { TipoId = 3, TipoTarea = "Programación" });
           modelBuilder.Entity<Tipos>().HasData(new Tipos { TipoId = 4, TipoTarea = "Prueba" });
        }



        
    }
}