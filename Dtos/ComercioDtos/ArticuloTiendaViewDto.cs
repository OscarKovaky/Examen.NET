using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.ComercioDtos
{
    public class ArticuloTiendaViewDto
    {
        public int ArticuloId { get; set; }

        public int TiendaId { get; set; }
        public string Codigo { get; set; }

        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public string Imagen { get; set; }

        public string ExtensionImagen { get; set; }

        public string NombreImagen { get; set; }

        public string Sucursal { get; set; }
        public string Direccion { get; set; }
    }
}
