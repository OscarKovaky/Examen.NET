using Dtos.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.FacturaFacade
{
    public interface IFacturaSystemFacade
    {
        Task<string> UpdateImpuestoFacade(ImpuestoUpdateModelDto requestImpuestoUpdateModelDto);

        Task<NXFCE100ResponseDTO> UpdateFacturaFacade(ActualizarNXFCE100DTO datosActualizados);

        Task<NXFCE100ResponseDTO> CrearFacturaFacade(NXFCE100Request request);

        Task<List<NXFCE100ResponseDTO>> ObtenerTodasLasFacturasFacade();

        Task<List<NXFCE102ResponseDTO>> ObtenerTodosLosImpuestosFacturaFacade();


        Task<byte[]> DescargarObtenerTodasLasFacturasFacadeCSV();

        Task<byte[]> DescargarObtenerTodasLosImpuestosFacadeCSV();

        Task<NXFCE100ResponseDTO> ObtenerDetalleFacturaFacade(string INTERID);
    }
}
