
using Dtos.ComercioDtos;
using Facade.ComercioFacade.Imp;
using Facade.UserFacade.Imp;
using Microsoft.AspNetCore.Mvc;

namespace Examen.NET.Controllers
{
    [Route("")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserFacade _logicFacade;

        public UserController(IUserFacade logicFacade)
        {
            _logicFacade = (logicFacade ?? throw new ArgumentNullException(nameof(logicFacade)));
        }

        [Route("ActualizarUser")]
        [HttpPut]
        public async Task<ResponseUserDto> CrearArticulo([FromQuery] RequestUserDto requestUserDto)
        {
            return await _logicFacade.UpdateUserFacade(requestUserDto);
        }

        [Route("Registrar")]
        [HttpPost]
        public async Task<ResponseUserDto> RegistrarUsuario([FromQuery] RequestUserDto requestUser)
        {
            return await _logicFacade.RegisterUserFacade(requestUser);
        }

        [Route("Login")]
        [HttpPost]
        public async Task<ResponseUserDto> LoginUser([FromQuery]RequestUserDto requestUserDto)
        {
            return await _logicFacade.LoginUserFacade(requestUserDto);
        }
    }
}
