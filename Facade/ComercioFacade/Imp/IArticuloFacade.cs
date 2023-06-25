using Dtos.ComercioDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ComercioFacade.Imp
{
    public interface IArticuloFacade
    {
        // crear un articulo - tienda 
        Task<int> AddArticuloTiendaFacade(RequestArticuloTiendaDto requestArticuloTiendaDto);
        // eliminar un articulo  - tienda eliminado en cascada

        Task<bool> DeleteArticuloTiendaFacade(int id);
        // actualizar un articulo - tienda

        Task<bool> UpdateArticuloTiendaFacade(RequestArticuloTiendaDto requestArticuloTiendaDto);

        //obtener lista de articulos - tienda 

        Task<List<ArticuloTiendaViewDto>> GetArticulosFacade();
    }
}
