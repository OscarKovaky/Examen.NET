using Dtos.View;
using Facade.FacturaFacade;
using Microsoft.AspNetCore.Mvc;
using Services.FacturaService;

namespace Examen.NET.Controllers
{

        [ApiController]
        [Route("api/[controller]")]
        public class FacturasController : ControllerBase
        {
            private readonly IFacturaSystemFacade _facturasFacade; // Reemplaza IFacturasService con el nombre real de tu servicio

            public FacturasController(IFacturaSystemFacade facturasFacade)
            {
                _facturasFacade = facturasFacade;
            }

            [HttpPost("CrearFactura")]
            public async Task<ActionResult<NXFCE100ResponseDTO>> CrearFacturaService(NXFCE100Request request)
            {
                var response = await _facturasFacade.CrearFacturaFacade(request);
                return Ok(response);
            }

            [HttpGet("DescargarTodasLasFacturasCSV")]
            public async Task<ActionResult<byte[]>> DescargarObtenerTodasLasFacturasServiceCSV()
            {
                var response = await _facturasFacade.DescargarObtenerTodasLasFacturasFacadeCSV();
                return File(response, "application/octet-stream", "TodasLasFacturas.csv");
            }

            [HttpGet("DescargarTodosLosImpuestosCSV")]
            public async Task<ActionResult<byte[]>> DescargarObtenerTodasLosImpuestosServiceCSV()
            {
                var response = await _facturasFacade.DescargarObtenerTodasLosImpuestosFacadeCSV();
                return File(response, "application/octet-stream", "TodosLosImpuestos.csv");
            }

            [HttpGet("ObtenerDetalleFactura")]
            public async Task<ActionResult<NXFCE100ResponseDTO>> ObtenerDetalleFactura(string INTERID)
            {
                var response = await _facturasFacade.ObtenerDetalleFacturaFacade(INTERID);
                if (response == null)
                {
                    return NotFound();
                }
                return Ok(response);
            }

            [HttpGet("ObtenerTodasLasFacturas")]
            public async Task<ActionResult<List<NXFCE100ResponseDTO>>> ObtenerTodasLasFacturasService()
            {
                var response = await _facturasFacade.ObtenerTodasLasFacturasFacade();
                return Ok(response);
            }

            [HttpGet("ObtenerTodosLosImpuestos")]
            public async Task<ActionResult<List<NXFCE102ResponseDTO>>> ObtenerTodosLosImpuestosService()
            {
                var response = await _facturasFacade.ObtenerTodosLosImpuestosFacturaFacade();
                return Ok(response);
            }

            [HttpPut("UpdateFactura")]
            public async Task<ActionResult<NXFCE100ResponseDTO>> UpdateFacturaService(ActualizarNXFCE100DTO datosActualizados)
            {
                var response = await _facturasFacade.UpdateFacturaFacade(datosActualizados);
                return Ok(response);
            }

            [HttpPut("UpdateImpuesto")]
            public async Task<ActionResult<string>> UpdateImpuestoService(ImpuestoUpdateModelDto requestImpuestoUpdateModelDto)
            {
                var response = await _facturasFacade.UpdateImpuestoFacade(requestImpuestoUpdateModelDto);
                return Ok(response);
            }
        }
}
