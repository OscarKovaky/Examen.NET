using Dtos.ComercioDtos;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ComercioService.Imp
{
    public interface IArticuloService
    {
        // crear un articulo - tienda 
        Task<int> AddArticuloTiendaService(RequestArticuloTiendaDto requestArticuloTiendaDto);
        // eliminar un articulo  - tienda eliminado en cascada

        Task<bool> DeleteArticuloTiendaService(int id);
        // actualizar un articulo - tienda

        Task<bool> UpdateArticuloTiendaService(RequestArticuloTiendaDto requestArticuloTiendaDto);

        //obtener lista de articulos - tienda 

        Task<List<ArticuloTiendaViewDto>> GetArticulosService();
    }
}
