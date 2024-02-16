using AutoMapper;
using ToDo_App.Model;
using ToDo_App.Model.DTO;

namespace ToDo_App
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Lists,ListDTO>().ReverseMap();
            CreateMap<Lists, ListCreateDTO>().ReverseMap();
            CreateMap<Lists, ListUpdateDTO>().ReverseMap();
        }
    }

}
