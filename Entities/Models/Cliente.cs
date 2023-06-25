using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public  class Cliente : IdentityUser
    {
        
        public string? Nombre { get; set; }

        public string? Apellidos { get; set; }

        public string? Direccion { get; set; }

        public List<Articulo>? Articulos { get; set; }


    }
}
