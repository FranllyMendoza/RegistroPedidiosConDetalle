using Microsoft.EntityFrameworkCore;
using RegistroPedidiosConDetalle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPedidiosConDetalle.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Suplidores> Suplidores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=Data\BDPedidos.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Suplidores>().HasData(
                new Suplidores { SuplidorId = 1, Nombres = "Juan Francisco Mendoza " }
                );

            modelBuilder.Entity<Suplidores>().HasData(
                new Suplidores { SuplidorId = 2, Nombres = "La Verdolaga" }
                );
            modelBuilder.Entity<Suplidores>().HasData(
                new Suplidores { SuplidorId = 3, Nombres = "Manuel Jimenes" }
                );

            modelBuilder.Entity<Productos>().HasData(
                new Productos { ProductoId = 1, Descripcion = "Refresco", Costo = 25, Inventario = 500 }
                );

            modelBuilder.Entity<Productos>().HasData(
                new Productos { ProductoId = 2, Descripcion = "Pollo frito", Costo = 150, Inventario = 300 }
                );

            modelBuilder.Entity<Productos>().HasData(
                new Productos { ProductoId = 3, Descripcion = "Vino Casero", Costo = 200, Inventario = 100 }
                );
        }



    }
}
