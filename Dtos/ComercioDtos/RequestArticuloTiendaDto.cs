using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.ComercioDtos
{
    public class RequestArticuloTiendaDto
    {   
        public int IdArticulo { get; set; } 
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
