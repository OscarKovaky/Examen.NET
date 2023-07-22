using Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.Ventas.Imp
{
    public interface IVentas
    {
        Task<List<Factura>> FindFacturasByPersona(int id);

        Task<int> StoreFactura(RequestFacturaDto requestFacturaDto);
    }
}
