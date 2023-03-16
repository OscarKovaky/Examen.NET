using Entities.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public class DataBaseContext: DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fk Composed
        }
    }
}
