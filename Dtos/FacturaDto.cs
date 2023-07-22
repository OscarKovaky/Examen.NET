using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos
{
    public class FacturaDto
    {
        public int FacturaId { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public int PersonaId { get; set; }

    }
}
