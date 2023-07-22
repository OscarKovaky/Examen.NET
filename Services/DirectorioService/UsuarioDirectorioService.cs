using AutoMapper;
using DataAccess.DAO.Diectorio.Imp;
using DataAccess.DAO.Ventas;
using DataAccess.DAO.Ventas.Imp;
using Dtos;
using Services.DirentorioService.Imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DirectorioService
{
    public class UsuarioDirectorioService : IDirectorioService
    {
        private readonly IDirectorio _directorioDao;
        private readonly IMapper _mapper;
        public UsuarioDirectorioService(IDirectorio directorioService, IMapper mapper)
        {
            _directorioDao = directorioService;
            _mapper = mapper;
        }
        public async Task<bool> DeletePersonasByIdentificacion(string identificacion)
        {
            return await _directorioDao.DeletePersonasByIdentificacion(identificacion);
        }

        public async Task<PersonaDto> FindPersonaByIdentificacion(string identificacion)
        {
            return _mapper.Map<PersonaDto>(await _directorioDao.FindPersonaByIdentificacion(identificacion));
        }

        public async Task<List<PersonaDto>> FindPersonas()
        {
            return _mapper.Map<List<PersonaDto>>(await _directorioDao.FindPersonas());
        }

        public Task<int> StorePersona(RequestDirectorioDto requestDirectorioDto)
        {
            return _directorioDao.StorePersona(requestDirectorioDto);
        }
    }
}
