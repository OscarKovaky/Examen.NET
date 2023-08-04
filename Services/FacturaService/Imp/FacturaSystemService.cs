using AutoMapper;
using DataAccess.DAO.Factura.Imp;
using Dtos;
using Dtos.View;
using Entities.Models.View;
using Services.FacturaService.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FacturaService.Imp
{
    public class FacturaSystemService : IFacturaService
    {
        private readonly IFacturaSystem _facturasSystemDao;
        private readonly IMapper _mapper;
        public FacturaSystemService(IFacturaSystem facturaSystem, IMapper mapper ) {
        
            _facturasSystemDao = facturaSystem;
            _mapper = mapper;   
        }

        public async Task<NXFCE100ResponseDTO> CrearFacturaService(NXFCE100Request request)
        {
            return _mapper.Map<NXFCE100ResponseDTO>(await _facturasSystemDao.CrearFactura(request));
        }

        public async Task<byte[]> DescargarObtenerTodasLasFacturasServiceCSV()
        {
            var bibliotecasDigitales = _mapper.Map<List<NXFCE100ResponseDTO>>(await _facturasSystemDao.ObtenerTodasLasFacturas());
            return FacturasToExcel.ConvertExcelNXFCE100(bibliotecasDigitales);
        }

        public async Task<byte[]> DescargarObtenerTodasLosImpuestosServiceCSV()
        {
            var bibliotecasDigitales = _mapper.Map<List<NXFCE102ResponseDTO>>(await _facturasSystemDao.ObtenerTodosLosImpuestos());
            return ImpuestosToExcel.ConvertExcelNXFCE102(bibliotecasDigitales);
        }

        public async Task<NXFCE100ResponseDTO> ObtenerDetalleFactura(string INTERID)
        {
            return _mapper.Map<NXFCE100ResponseDTO>(await _facturasSystemDao.ObtenerDetalleFactura(INTERID));
        }

        public async Task<List<NXFCE100ResponseDTO>> ObtenerTodasLasFacturasService()
        {
            return _mapper.Map<List<NXFCE100ResponseDTO>>(await _facturasSystemDao.ObtenerTodasLasFacturas());
        }

        public async Task<List<NXFCE102ResponseDTO>> ObtenerTodosLosImpuestosService()
        {
            return _mapper.Map<List<NXFCE102ResponseDTO>>(await _facturasSystemDao.ObtenerTodosLosImpuestos());
        }

        public async Task<NXFCE100ResponseDTO> UpdateFacturaService(ActualizarNXFCE100DTO datosActualizados)
        {
            return _mapper.Map<NXFCE100ResponseDTO>(await _facturasSystemDao.UpdateFactura(datosActualizados));
        }

        public async Task<string> UpdateImpuestoService(ImpuestoUpdateModelDto requestImpuestoUpdateModelDto)
        {
            return await _facturasSystemDao.UpdateImpuesto(requestImpuestoUpdateModelDto);
        }
    }
}
