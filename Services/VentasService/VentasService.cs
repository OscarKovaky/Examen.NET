using AutoMapper;
using DataAccess.DAO.Ventas;
using DataAccess.DAO.Ventas.Imp;
using Dtos;
using Services.VentasService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.VentasService
{
    public class VentasService : IVentasService
    {
        private readonly IVentas _ventasDao;
        private readonly IMapper _mapper;

        public VentasService(IMapper mapper,IVentas ventas)
        {
            _ventasDao = ventas;
            _mapper = mapper;
        }

        public async Task<List<FacturaDto>> FindFacturasByPersona(int id)
        {
            return _mapper.Map<List<FacturaDto>>(await _ventasDao.FindFacturasByPersona(id));
        }

        public Task<int> StoreFactura(RequestFacturaDto requestFacturaDto)
        {
            return _ventasDao.StoreFactura(requestFacturaDto);
        }
    }
}
