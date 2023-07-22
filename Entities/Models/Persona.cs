﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Persona
    {
        public int PersonaId { get; set; }
        
        public string? Nombre { get; set; }

        public string? ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public string? Identificacion { get; set; }

        public List<Factura>? Facturas { get; set; }

    }
}