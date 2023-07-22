
using Dtos;
using Facade.DirectorioFacade;
using Facade.UserFacade.Imp;
using Microsoft.AspNetCore.Mvc;

namespace Examen.NET.Controllers
{
    [Route("User")]
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


        [HttpPost("")]
        public async Task<int> CrearUsuarioDirectorio(RequestDirectorioDto requestUser)
        {
            return await _directorioFacadeUser.StorePersona(requestUser);
        }

        [HttpDelete("{identificacion}")]
        public async Task<bool> BorrarUsuarioDirectorio(string identificacion)
        {
            return await _directorioFacadeUser.DeletePersonasByIdentificacion(identificacion);
        }


        [HttpGet]
        public async Task<List<PersonaDto>> ObtenerListaDirectorio()
        {
            return await _directorioFacadeUser.FindPersonas();
        }


        [HttpGet("{identificacion}")]
        public async Task<PersonaDto> ObtenerIdentificacion(string identificacion)
        {
            return await _directorioFacadeUser.FindPersonaByIdentificacion(identificacion);
        }
    }
}
