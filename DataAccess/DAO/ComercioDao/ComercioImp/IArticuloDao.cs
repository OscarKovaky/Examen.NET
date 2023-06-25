using Dtos.ComercioDtos;
using Entities.Models;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.ComercioDao.ComercioImp
{
    public  interface IArticuloDao
    {
        // crear un articulo - tienda 
        Task<int> AddArticuloTienda(RequestArticuloTiendaDto requestArticuloTiendaDto);
        // eliminar un articulo  - tienda eliminado en cascada

        Task<bool> DeleteArticuloTienda(int id);
        // actualizar un articulo - tienda

        Task<bool> UpdateArticuloTienda(RequestArticuloTiendaDto requestArticuloTiendaDto);

        //obtener lista de articulos - tienda 

        Task<List<ArticuloTiendaViewModel>> GetArticulos();
    }
}
