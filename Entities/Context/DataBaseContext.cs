
using Entities.Models;
using Microsoft.AspNetCore.Identity;
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

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Factura> Facturas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Factura>().
                HasOne(i => i.Persona)
                .WithMany(a => a.Facturas)
                .HasForeignKey(i => i.PersonaId);

            modelBuilder.Ignore<IdentityUserLogin<string>>();
        }
    }
}
