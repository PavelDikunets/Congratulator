using AutoMapper;
using Congratulator.Db.Models;
using Congratulator.WebApp.Models;

namespace Congratulator.WebApp.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Person, PersonViewModel>().ReverseMap();
        } 
    }
}
