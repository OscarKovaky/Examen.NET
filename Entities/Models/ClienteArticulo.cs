using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ClienteArticulo
    {
        public string? ClienteId { get; set; }
        public int ArticuloId { get; set; }

        public DateTime Fecha { get; set; }

        public Cliente? Cliente { get; set; }

        public Articulo? Articulo { get; set; }
    }
}
