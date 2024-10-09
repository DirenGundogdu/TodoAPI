using AutoMapper;
using TodoAPI.Contracts;
using TodoAPI.Models;

namespace TodoAPI.MappingProfiles;

public class AutoMapperProfile : Profile
{
   public AutoMapperProfile()
   {
      CreateMap<CreateTodoRequest, Todo>()
         .ForMember(x => x.Id, opt => opt.Ignore())
         .ForMember(x => x.CreatedAt, opt => opt.Ignore())
         .ForMember(x => x.UpdateAt, opt => opt.Ignore());
      
      
      CreateMap<UpdateTodoRequest, Todo>()
         .ForMember(x => x.Id, opt => opt.Ignore())
         .ForMember(x => x.CreatedAt, opt => opt.Ignore())
         .ForMember(x => x.UpdateAt, opt => opt.Ignore());

   }
}