using AutoMapper;
using Todo_API.DTO;
using Todo_API.Models;

namespace Todo_API.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Todo, TodoDTO>();
        }
    }
}
