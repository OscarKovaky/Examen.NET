
using Entities.Models;
using Entities.Models.View;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

        public DbSet<NXFCE100> NXFCE100s { get; set; }
        public DbSet<NXFCE101> NXFCE101s { get; set; }
        public DbSet<NXFCE102> NXFCE102s { get; set; }
    }
}
