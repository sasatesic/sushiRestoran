using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SushiRestoran.Models;
using SushiRestoran.Dtos;

namespace SushiRestoran.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Jelo, JeloDto>();
            Mapper.CreateMap<JeloDto, Jelo>();
        }
    }
}