﻿
using DataAccess.DAO.Ventas;
using Dtos;
using Facade.VentasFacade;
using Microsoft.AspNetCore.Mvc;

namespace Examen.NET.Controllers
{
    [Route("")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly IUsuarioVentasFacade _usuarioVentasFacade;
        public VentasController(IUsuarioVentasFacade usuarioVentasFacade) { 
            _usuarioVentasFacade = usuarioVentasFacade;
        }

        [HttpGet("{id}/listVentas")]
        public async Task<List<FacturaDto>> Get(int id)
        {
            return await _usuarioVentasFacade.FindFacturasByPersonaFacade(id);
        }

        [HttpPost("crearFactura")]
        public async Task<int> Post(RequestFacturaDto requestFacturaDto)
        {
            return await _usuarioVentasFacade.StoreFacturaFacade(requestFacturaDto);
        }


    }
}