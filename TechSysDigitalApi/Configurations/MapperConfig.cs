using AutoMapper;
using DataInterface.Dtos;
using TechSysDigitalApi.Models;

namespace TechSysDigitalApi.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Musician, MusicianDto>().ReverseMap();
        }
    }
}
