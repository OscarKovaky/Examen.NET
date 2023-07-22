using Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.DirectorioFacade
{
    public interface IDirectorioFacadeUser
    {
        Task<PersonaDto> FindPersonaByIdentificacion(string identificacion);

        Task<List<PersonaDto>> FindPersonas();

        Task<bool> DeletePersonasByIdentificacion(string identificacion);

        Task<int> StorePersona(RequestDirectorioDto requestDirectorioDto);
    }
}
