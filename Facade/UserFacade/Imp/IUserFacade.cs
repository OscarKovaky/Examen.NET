using Dtos.ComercioDtos;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.UserFacade.Imp
{
    public interface IUserFacade
    {
        // registrar un usuario
        Task<ResponseUserDto> RegisterUserFacade(RequestUserDto requestUserDto);

        //login Usuario

        Task<ResponseUserDto> LoginUserFacade(RequestUserDto requestUserDto);

        // eliminar un Usuario eliminado 

        Task<bool> DeleteUserFacade(int id);
        // actualizar un Usuario

        Task<ResponseUserDto> UpdateUserFacade(RequestUserDto requestUserDto);

        //obtener lista de ordenes usuario - articulo

        Task<List<ArticuloTiendaViewModel>> GetArticulosUserFacade();
    }
}
