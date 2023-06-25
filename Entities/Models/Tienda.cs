using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public  class Tienda
    {
        public int Id { get; set; }
        public string? Sucursal { get; set; }
        public string? Direccion { get; set; }

        public List<Articulo>? Articulos { get; set; }
    }
}
