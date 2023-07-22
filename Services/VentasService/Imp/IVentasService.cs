using Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.VentasService.Imp
{
    public interface IVentasService
    {
        Task<List<FacturaDto>> FindFacturasByPersona(int id);

        Task<int> StoreFactura(RequestFacturaDto requestFacturaDto);
    }
}
