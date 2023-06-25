using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.ComercioDtos
{
    public class RequestUserDto
    {
        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Direccion { get; set; }

        public string Token { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
