using DataAccess.DAO.ComercioDao.ComercioImp;
using Dtos.ComercioDtos;
using Entities.Context;
using Entities.Models;
using Entities.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.ComercioDao
{
    public class ArticuloDao : IArticuloDao
    {
        private readonly IDataBaseContext _databaseContext;

        public ArticuloDao(IDataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<int> AddArticuloTienda(RequestArticuloTiendaDto requestArticuloTiendaDto)
        {
            var articulo = new Articulo
            {
                Codigo = requestArticuloTiendaDto.Codigo,
                Descripcion = requestArticuloTiendaDto.Descripcion,
                Precio = requestArticuloTiendaDto.Precio,
               // Imagen = Convert.FromBase64String(requestArticuloTiendaDto.Imagen),
                ExtensionImagen = requestArticuloTiendaDto.ExtensionImagen,
                NombreImagen = requestArticuloTiendaDto.NombreImagen
            };
             _databaseContext.Articulos.Add(articulo);
            var resultArticulo = await((DataBaseContext)_databaseContext).SaveChangesAsync();

            if (resultArticulo == 0)
            {
                return 0;
            }

            var tienda = new Tienda
            {
                Sucursal = requestArticuloTiendaDto.Sucursal,
                Direccion = requestArticuloTiendaDto.Direccion
            };

            _databaseContext.Tiendas.Add(tienda);
           var  resultTienda = await ((DataBaseContext)_databaseContext).SaveChangesAsync();

            if (resultTienda == 0)
            {
                return 0;
            }

            var articuloTienda = new ArticuloTienda { ArticuloId = articulo.Id, TiendaId  = tienda.Id, Fecha = DateTime.Now };

            _databaseContext.ArticuloTienda.Add(articuloTienda);
            var resultArticuloTienda = await ((DataBaseContext)_databaseContext).SaveChangesAsync();

            if (resultArticuloTienda == 0)
            {
                return 0;
            }

            return articulo.Id;
        }

        public async Task<bool> DeleteArticuloTienda(int id)
        {
            var Articulo = await _databaseContext.Articulos
               .Where(e => e.Id == id).FirstOrDefaultAsync();

            if (Articulo == null)
            {
                return false;
            }


             _databaseContext.Articulos.Remove(Articulo);
             await ((DataBaseContext)_databaseContext).SaveChangesAsync();
            return true;
        }

        public   async Task<List<ArticuloTiendaViewModel>> GetArticulos()
        {
            var ArticulosConTiendas = await (from articuloTienda in _databaseContext.ArticuloTienda
                                  join articulo in _databaseContext.Articulos on articuloTienda.ArticuloId equals articulo.Id
                                  join tienda in _databaseContext.Tiendas on articuloTienda.TiendaId equals tienda.Id
                                  select new ArticuloTiendaViewModel
                                  {
                                      ArticuloId = articulo.Id,
                                      TiendaId = tienda.Id,
                                      Codigo = articulo.Codigo,
                                      Descripcion = articulo.Descripcion,
                                      //Imagen = Convert.ToBase64String(articulo.Imagen),
                                      ExtensionImagen = articulo.ExtensionImagen,
                                      NombreImagen = articulo.NombreImagen,
                                      Sucursal = tienda.Sucursal,
                                      Direccion = tienda.Direccion,

                                  }).AsQueryable().ToListAsync();



            return ArticulosConTiendas;
              
        }

        public async Task<bool> UpdateArticuloTienda(RequestArticuloTiendaDto requestArticuloTiendaDto)
        {
            var ArticuloTiendaModel = await _databaseContext.Articulos
              .Where(e => e.Id == requestArticuloTiendaDto.IdArticulo).FirstOrDefaultAsync();

            if(ArticuloTiendaModel == null)
            {
                return false;
            }

            ArticuloTiendaModel.Codigo = requestArticuloTiendaDto.Codigo ?? ArticuloTiendaModel.Codigo;
            ArticuloTiendaModel.Descripcion = requestArticuloTiendaDto.Descripcion ?? ArticuloTiendaModel.Descripcion;
            ArticuloTiendaModel.Precio = requestArticuloTiendaDto.Precio;
            //ArticuloTiendaModel.Imagen = Convert.FromBase64String(requestArticuloTiendaDto.Imagen) ?? ArticuloTiendaModel.Imagen;
            ArticuloTiendaModel.NombreImagen = requestArticuloTiendaDto.NombreImagen ?? ArticuloTiendaModel.NombreImagen;
            ArticuloTiendaModel.ExtensionImagen = requestArticuloTiendaDto.ExtensionImagen ?? ArticuloTiendaModel.ExtensionImagen;
            
            _databaseContext.Articulos.Update(ArticuloTiendaModel);
            await ((DataBaseContext)_databaseContext).SaveChangesAsync();
            return true;

        }
    }
}
