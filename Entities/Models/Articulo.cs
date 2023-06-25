using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Articulo
    {
        public int Id { get; set; }

        public string? Codigo { get; set; }

        public string? Descripcion { get; set; } 
        public double Precio { get; set; }

        public byte[]? Imagen { get ; set; }

        public string? ExtensionImagen { get; set; }

        public string? NombreImagen { get; set; }
        public DateTime FechaCreacion { get; set; }

        public List<Tienda>? Tiendas { get; set; } 

        public List<Cliente>? Clientes { get; set; }
    }
}
