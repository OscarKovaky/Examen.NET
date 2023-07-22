using DataAccess.DAO.Ventas;
using Dtos;
using Services.VentasService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.VentasFacade.Imp
{
    public class UsuarioVentasFacade : IUsuarioVentasFacade
    {
        private readonly IVentasService _ventasService;

        public UsuarioVentasFacade(IVentasService ventasService)
        {
            _ventasService = ventasService;
        }

        public async Task<List<FacturaDto>> FindFacturasByPersonaFacade(int id)
        {
            return await _ventasService.FindFacturasByPersona(id);
        }

        public Task<int> StoreFacturaFacade(RequestFacturaDto requestFacturaDto)
        {
            return _ventasService.StoreFactura(requestFacturaDto);
        }
    }
}
