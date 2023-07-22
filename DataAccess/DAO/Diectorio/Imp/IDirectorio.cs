using Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.Diectorio.Imp
{
    public interface IDirectorio
    {
        Task<Persona> FindPersonaByIdentificacion(string identificacion);

        Task<List<Persona>> FindPersonas();

        Task<bool> DeletePersonasByIdentificacion(string identificacion);

        Task<int> StorePersona(RequestDirectorioDto requestDirectorioDto);

    }
}
