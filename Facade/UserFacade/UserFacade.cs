﻿using Dtos.ComercioDtos;
using Entities.View;
using Facade.UserFacade.Imp;
using Services.UserService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.UserFacade
{
    public class UserFacade : IUserFacade
    {
        private readonly IUserService _userService;

        public UserFacade(IUserService userService)
        {
            _userService = userService;
        }
        public Task<bool> DeleteUserFacade(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArticuloTiendaViewModel>> GetArticulosUserFacade()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseUserDto> LoginUserFacade(RequestUserDto requestUserDto)
        {
            return _userService.LoginUserService(requestUserDto);
        }

        public Task<ResponseUserDto> RegisterUserFacade(RequestUserDto requestUserDto)
        {
            return _userService.RegisterUserService(requestUserDto);
        }

        public Task<ResponseUserDto> UpdateUserFacade(RequestUserDto requestUserDto)
        {
            return _userService.UpdateUserService(requestUserDto);
        }
    }
}
