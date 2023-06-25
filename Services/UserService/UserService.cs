using DataAccess.DAO.UserDao.Imp;
using Dtos.ComercioDtos;
using Entities.View;
using Services.UserService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserDao _userDao;

        public UserService(IUserDao userDao)
        {
            _userDao = userDao;
        }
        public Task<bool> DeleteUserService(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticuloTiendaViewModel>> GetArticulosUserService()
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseUserDto> LoginUserService(RequestUserDto requestUserDto)
        {
            return  await _userDao.LoginUser(requestUserDto);
        }

        public async Task<ResponseUserDto> RegisterUserService(RequestUserDto requestUserDto)
        {
            return await _userDao.RegisterUser(requestUserDto);
        }

        public async Task<ResponseUserDto> UpdateUserService(RequestUserDto requestUserDto)
        {
            return await _userDao.UpdateUser(requestUserDto);
        }
    }
}
