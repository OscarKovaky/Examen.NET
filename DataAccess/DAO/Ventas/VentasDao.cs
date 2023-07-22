using DataAccess.DAO.Ventas.Imp;
using DataAccess.Utils;
using Dtos;
using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.Ventas
{
    public class VentasDao : IVentas
    {
        private readonly IDataBaseContext _databaseContext;


        public VentasDao(IDataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Task<List<Factura>> FindFacturasByPersona(int id)
        {
            return _databaseContext.Facturas.Where(e => e.PersonaId == id).ToListAsync();
        }

        public async Task<int> StoreFactura(RequestFacturaDto requestFacturaDto)
        {
            if (requestFacturaDto.UsuarioId == 0)
            {
                throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Se requiere el IdUsuario que emite la factura" });
            }

            var Factura = new Factura() {
                Fecha = DateTime.UtcNow,
                Monto = requestFacturaDto.Monto,
                PersonaId = requestFacturaDto.UsuarioId
          
            };

             _databaseContext.Facturas.Add(Factura);
            await ((DataBaseContext)_databaseContext).SaveChangesAsync();

            return Factura.FacturaId;
        }
    }
}
