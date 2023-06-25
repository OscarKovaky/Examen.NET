using AutoMapper;
using DataAccess.DAO.ComercioDao.ComercioImp;
using Dtos.ComercioDtos;
using Services.ComercioService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ComercioService
{
    public class ArticuloService : IArticuloService
    {
        private readonly IArticuloDao _articuloDao;
        private readonly IMapper _mapper;

        public ArticuloService(IArticuloDao articuloDao, IMapper mapper)
        {
            _articuloDao = articuloDao;
            _mapper = mapper;
        }

        public Task<int> AddArticuloTiendaService(RequestArticuloTiendaDto requestArticuloTiendaDto)
        {
            var result = _articuloDao.AddArticuloTienda(requestArticuloTiendaDto);
            return result;
        }

        public Task<bool> DeleteArticuloTiendaService(int id)
        {
            var result = _articuloDao.DeleteArticuloTienda(id);
            return result;
        }

        public async Task<List<ArticuloTiendaViewDto>> GetArticulosService()
        {
            return _mapper.Map<List<ArticuloTiendaViewDto>>(await _articuloDao.GetArticulos());
        }

        public Task<bool> UpdateArticuloTiendaService(RequestArticuloTiendaDto requestArticuloTiendaDto)
        {
            var result = _articuloDao.UpdateArticuloTienda(requestArticuloTiendaDto);
            return result;
        }
    }
}
