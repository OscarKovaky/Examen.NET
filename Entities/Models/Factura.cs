using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Factura
    {
        public int FacturaId { get; set; }  

        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public int PersonaId { get; set; }

        public Persona? Persona { get; set; }
    }
}
