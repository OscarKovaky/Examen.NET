using AutoMapper;
using Dtos;
using Dtos.View;
using Entities.Models;
using Entities.Models.View;
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

            this.CreateMap<NXFCE100, NXFCE100ResponseDTO>();
            this.CreateMap<NXFCE100ResponseDTO, NXFCE100>();

            this.CreateMap<NXFCE102, NXFCE102ResponseDTO>();
            this.CreateMap<NXFCE102ResponseDTO, NXFCE102>();
        }
    }
}
