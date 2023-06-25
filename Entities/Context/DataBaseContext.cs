
using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public class DataBaseContext:  IdentityDbContext<Cliente>, IDataBaseContext
    {
     
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
           
        }

       


        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Tienda> Tiendas { get; set; }
        public DbSet<ArticuloTienda> ArticuloTienda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Articulo>().
                HasMany(p => p.Tiendas)
                .WithMany(p => p.Articulos)
                .UsingEntity<ArticuloTienda>(
                pg => pg.HasOne(prop => prop.Tienda)
                .WithMany().HasForeignKey  (p => p.TiendaId),
                pg => pg.HasOne(prop => prop.Articulo)
                .WithMany()
                .HasForeignKey(prop => prop.ArticuloId)
                );

            modelBuilder.Entity<Cliente>().
                HasMany(p => p.Articulos)
                .WithMany(p => p.Clientes)
                .UsingEntity<ClienteArticulo>(
                pg => pg.HasOne(prop => prop.Articulo)
                .WithMany().HasForeignKey (prop => prop.ArticuloId),
                pg => pg.HasOne(prop => prop.Cliente)
                .WithMany()
                .HasForeignKey(prop => prop.ClienteId)
                );
        }
    }
}
