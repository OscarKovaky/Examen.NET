using AutoMapper;
using Dtos.ComercioDtos;
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


            this.CreateMap<ArticuloTiendaViewModel, ArticuloTiendaViewDto>();
            this.CreateMap<ArticuloTiendaViewDto, ArticuloTiendaViewModel>();


        }
    }
}
