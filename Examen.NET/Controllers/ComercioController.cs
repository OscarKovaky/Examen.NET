
using Dtos.ComercioDtos;
using Facade.ComercioFacade.Imp;
using Microsoft.AspNetCore.Mvc;

namespace Examen.NET.Controllers
{
    [Route("")]
    [ApiController]
    public class ComercioController : ControllerBase
    {
        private readonly IArticuloFacade _logicFacade;

        public ComercioController(IArticuloFacade logicFacade)
        {
            _logicFacade = logicFacade ?? throw new ArgumentNullException(nameof(logicFacade));
        }

        [Route("crearArticulo")]
        [HttpPost]
        public async Task<int> CrearArticulo([FromQuery] RequestArticuloTiendaDto requestArticuloTiendaDto)
        {
            return await _logicFacade.AddArticuloTiendaFacade(requestArticuloTiendaDto);
        }

        [Route("obtenerArticulos")]
        [HttpGet]
        public async Task<List<ArticuloTiendaViewDto>> getArticulos()
        {
            return await _logicFacade.GetArticulosFacade();
        }

        [Route("actualizarArticulo")]
        [HttpPut]
        public async Task<bool> UpdateArticulo([FromQuery] RequestArticuloTiendaDto requestArticuloTiendaDto)
        {
            return await _logicFacade.UpdateArticuloTiendaFacade(requestArticuloTiendaDto);
        }

        [Route("borrarArticulo")]
        [HttpDelete]
        public async Task<bool> DeleteArticulo([FromQuery] int id)
        {
            return await _logicFacade.DeleteArticuloTiendaFacade(id);
        }

        

    }
}
