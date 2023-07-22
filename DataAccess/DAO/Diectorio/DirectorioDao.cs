using DataAccess.DAO.Diectorio.Imp;
using DataAccess.Utils;
using Dtos;
using Entities.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO.Diectorio
{
    public class DirectorioDao : IDirectorio
    {
        private readonly IDataBaseContext _databaseContext;


        public DirectorioDao(IDataBaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<bool> DeletePersonasByIdentificacion(string identificacion)
        {
            var directory = _databaseContext.Personas.FirstOrDefault(e => e.Identificacion.ToUpper().Contains(identificacion.ToUpper()));
            if (directory == null)
            {
                throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Se requiere una identificacion" });
            }

            _databaseContext.Personas.Remove(directory);
            await((DataBaseContext)_databaseContext).SaveChangesAsync();
            return true;
        }

        public async Task<Persona> FindPersonaByIdentificacion(string identificacion)
        {
            var directory =  _databaseContext.Personas.FirstOrDefault(e => e.Identificacion.ToUpper().Contains(identificacion.ToUpper()));

            if (directory == null)
            {
                throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "No existe la persona" });
            }

            return directory;
        }

        public Task<List<Persona>> FindPersonas()
        {
            var personas = _databaseContext.Personas.ToListAsync();
            return personas;
        }

        public async Task<int> StorePersona(RequestDirectorioDto requestDirectorioDto)
        {
            if (string.IsNullOrEmpty(requestDirectorioDto.Nombre)  ||
                string.IsNullOrEmpty(requestDirectorioDto.ApellidoMaterno) ||
                string.IsNullOrEmpty(requestDirectorioDto.ApellidoPaterno) ||
                string.IsNullOrEmpty(requestDirectorioDto.Identificacion)
                )
            {
                // La cadena está vacía o es nula campo requerido

                throw new ManejadorExcepcion(HttpStatusCode.InternalServerError, new { mensaje = "Existe un campo Vacio" });
            }

            var Persona = new Persona()
            {
                Nombre = requestDirectorioDto.Nombre,
                ApellidoMaterno = requestDirectorioDto.ApellidoMaterno,
                ApellidoPaterno = requestDirectorioDto.ApellidoPaterno,
                Identificacion = requestDirectorioDto.Identificacion

            };

            _databaseContext.Personas.Add(Persona);
            await((DataBaseContext)_databaseContext).SaveChangesAsync();

            return Persona.PersonaId;
        }
    }
}
