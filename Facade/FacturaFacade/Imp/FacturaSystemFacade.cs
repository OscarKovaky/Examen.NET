using Dtos.View;
using Services.FacturaService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.FacturaFacade.Imp
{
    public class FacturaSystemFacade : IFacturaSystemFacade
    {
        private readonly IFacturaService _facturasService;
        public FacturaSystemFacade(IFacturaService facturasService) { 
            _facturasService = facturasService;
        }
        public async Task<NXFCE100ResponseDTO> CrearFacturaFacade(NXFCE100Request request)
        {
            var response = await _facturasService.CrearFacturaService(request);
            return response;
        }

        public async Task<byte[]> DescargarObtenerTodasLasFacturasFacadeCSV()
        {
            var response = await _facturasService.DescargarObtenerTodasLasFacturasServiceCSV();
            return response;
        }

        public async Task<byte[]> DescargarObtenerTodasLosImpuestosFacadeCSV()
        {
            var response = await _facturasService.DescargarObtenerTodasLosImpuestosServiceCSV();
            return response;
        }

        public async Task<NXFCE100ResponseDTO> ObtenerDetalleFacturaFacade(string INTERID)
        {
            var response = await _facturasService.ObtenerDetalleFactura(INTERID);
            return response;
        }

        public async Task<List<NXFCE100ResponseDTO>> ObtenerTodasLasFacturasFacade()
        {
            var response = await _facturasService.ObtenerTodasLasFacturasService();
            return response;
        }

        public async Task<List<NXFCE102ResponseDTO>> ObtenerTodosLosImpuestosFacturaFacade()
        {
            var response = await _facturasService.ObtenerTodosLosImpuestosService();
            return response;
        }

        public async Task<NXFCE100ResponseDTO> UpdateFacturaFacade(ActualizarNXFCE100DTO datosActualizados)
        {
            var response = await _facturasService.UpdateFacturaService(datosActualizados);
            return response;
        }

        public async Task<string> UpdateImpuestoFacade(ImpuestoUpdateModelDto requestImpuestoUpdateModelDto)
        {
            var response = await _facturasService.UpdateImpuestoService(requestImpuestoUpdateModelDto);
            return response;
        }
    }
}
