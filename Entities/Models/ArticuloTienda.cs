using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ArticuloTienda
    {
        public int ArticuloId { get; set; }
        public int TiendaId { get; set; }
        public DateTime Fecha { get; set; }

        public Articulo? Articulo { get; set; }

        public Tienda? Tienda { get; set; }

    }
}
