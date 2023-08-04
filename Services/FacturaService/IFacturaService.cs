using Dtos.View;
using Entities.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.FacturaService
{
    public interface IFacturaService
    {
        Task<string> UpdateImpuestoService(ImpuestoUpdateModelDto requestImpuestoUpdateModelDto);

        Task<NXFCE100ResponseDTO> UpdateFacturaService(ActualizarNXFCE100DTO datosActualizados);

        Task<NXFCE100ResponseDTO> CrearFacturaService(NXFCE100Request request);

        Task<List<NXFCE100ResponseDTO>> ObtenerTodasLasFacturasService();

        Task<List<NXFCE102ResponseDTO>> ObtenerTodosLosImpuestosService();


        Task<byte[]> DescargarObtenerTodasLasFacturasServiceCSV();

        Task<byte[]> DescargarObtenerTodasLosImpuestosServiceCSV();

        Task<NXFCE100ResponseDTO> ObtenerDetalleFactura(string INTERID);
    }
}
