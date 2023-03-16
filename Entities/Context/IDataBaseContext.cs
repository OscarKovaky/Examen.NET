using Entities.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Context
{
    public interface IDataBaseContext
    {
        DbSet<Accounts> Accounts { get; set; }

        DbSet<Balance> Balances { get; set; }

        DbSet<Transaction> Transactions { get; set; }
    }
}
