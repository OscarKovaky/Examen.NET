
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
        DbSet<Articulo> Articulos { get; set; }

        DbSet<Tienda> Tiendas { get; set; }

        DbSet <ArticuloTienda> ArticuloTienda { get; set; }
    }
}
