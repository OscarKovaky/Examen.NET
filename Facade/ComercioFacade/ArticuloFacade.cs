using Dtos.ComercioDtos;
using Facade.ComercioFacade.Imp;
using Services.ComercioService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ComercioFacade
{
    public class ArticuloFacade : IArticuloFacade
    {
        private readonly IArticuloService _articuloService;
        public ArticuloFacade(IArticuloService articuloService)
        {
            _articuloService = articuloService;
        }
        public Task<int> AddArticuloTiendaFacade(RequestArticuloTiendaDto requestArticuloTiendaDto)
        {
            var result = _articuloService.AddArticuloTiendaService(requestArticuloTiendaDto);
            return result;
        }

        public Task<bool> DeleteArticuloTiendaFacade(int id)
        {
            var result = _articuloService.DeleteArticuloTiendaService(id);
            return result;
        }

        public Task<List<ArticuloTiendaViewDto>> GetArticulosFacade()
        {
            return _articuloService.GetArticulosService();
        }

        public Task<bool> UpdateArticuloTiendaFacade(RequestArticuloTiendaDto requestArticuloTiendaDto)
        {
            var result = _articuloService.UpdateArticuloTiendaService(requestArticuloTiendaDto);
            return result;
        }
    }
}
