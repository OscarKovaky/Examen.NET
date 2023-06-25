using Dtos.ComercioDtos;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.UserService.Imp
{
    public interface IUserService
    {
        // registrar un usuario
        Task<ResponseUserDto> RegisterUserService(RequestUserDto requestUserDto);

        //login Usuario

        Task<ResponseUserDto> LoginUserService(RequestUserDto requestUserDto);

        // eliminar un Usuario eliminado 

        Task<bool> DeleteUserService(int id);
        // actualizar un Usuario

        Task<ResponseUserDto> UpdateUserService(RequestUserDto requestUserDto);

        //obtener lista de ordenes usuario - articulo

        Task<List<ArticuloTiendaViewModel>> GetArticulosUserService();
    }
}
