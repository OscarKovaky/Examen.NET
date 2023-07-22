
using Entities.Models;
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
        DbSet<Persona> Personas { get; set; }

        DbSet<Factura> Facturas { get; set; }

    }
}
