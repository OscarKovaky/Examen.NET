using Dtos;
using Services.DirentorioService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.DirectorioFacade
{
    public class DirectorioFacadeUser : IDirectorioFacadeUser
    {
        private readonly IDirectorioService _directorioService;
        public DirectorioFacadeUser(IDirectorioService directorioService)
        {
            _directorioService = directorioService;
        }
        public async Task<bool> DeletePersonasByIdentificacion(string identificacion)
        {
            return await _directorioService.DeletePersonasByIdentificacion(identificacion);
        }

        public async Task<PersonaDto> FindPersonaByIdentificacion(string identificacion)
        {
            return await _directorioService.FindPersonaByIdentificacion(identificacion);
        }

        public async Task<List<PersonaDto>> FindPersonas()
        {
            return await _directorioService.FindPersonas();
        }

        public async Task<int> StorePersona(RequestDirectorioDto requestDirectorioDto)
        {
            return await _directorioService.StorePersona(requestDirectorioDto);
        }
    }
}
