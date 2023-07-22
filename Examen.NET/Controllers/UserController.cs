
using Dtos;
using Facade.DirectorioFacade;
using Facade.UserFacade.Imp;
using Microsoft.AspNetCore.Mvc;

namespace Examen.NET.Controllers
{
    [Route("")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserFacade _logicFacade;
        private readonly IDirectorioFacadeUser _directorioFacadeUser;
        public UserController(IUserFacade logicFacade, IDirectorioFacadeUser directorioFacadeUser)
        {
            _logicFacade = (logicFacade ?? throw new ArgumentNullException(nameof(logicFacade)));
            _directorioFacadeUser = directorioFacadeUser;
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

        [Route("crearUsuarioDirectorio")]
        [HttpPost]
        public async Task<int> crearUsuarioDirectorio([FromQuery] RequestDirectorioDto requestUser)
        {
            return await _directorioFacadeUser.StorePersona(requestUser);
        }

        [Route("BorrarUsuarioDirectorio")]
        [HttpDelete]
        public async Task<bool> BorrarUsuarioDirectorio([FromQuery] string identificacion)
        {
            return await _directorioFacadeUser.DeletePersonasByIdentificacion(identificacion);
        }

        [Route("obtenerListaDirectorio")]
        [HttpGet]
        public async Task<List<PersonaDto>> obtenerListaDirectorio()
        {
            return await _directorioFacadeUser.FindPersonas();
        }

        [Route("obtenerIdentificacion")]
        [HttpGet]
        public async Task<PersonaDto> obtenerIdentificacion([FromQuery] string identificacion)
        {
            return await _directorioFacadeUser.FindPersonaByIdentificacion(identificacion);
        }
    }
}
