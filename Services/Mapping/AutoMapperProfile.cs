using AutoMapper;
using Dtos;
using Entities.Models;
using Entities.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {

            this.CreateMap<Factura, FacturaDto>();
            this.CreateMap<FacturaDto, Factura>();

            this.CreateMap<Persona, PersonaDto>();
            this.CreateMap<PersonaDto, Persona>();
        }
    }
}
