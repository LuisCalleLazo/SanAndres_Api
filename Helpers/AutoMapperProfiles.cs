using AutoMapper;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;

namespace SanAndres_Api.Helpers
{
  public class AutoMapperProfiles : Profile
  {
    public AutoMapperProfiles()
    {
      CreateMap<User, UserResponseDto>();
      CreateMap<User, UserToListDto>();

      CreateMap<AuthRegisterDto, User>();
      CreateMap<AuthRegisterDto, UserInfo>();

      CreateMap<AuthResponseDto, Token>()
      .ForMember(dest => dest.UserId, opt => opt.Ignore())
      .ForMember(dest => dest.User, opt => opt.Ignore());
    }
    
    private int CalculateAge(DateTime birthDate)
    {
      var today = DateTime.Today;
      var age = today.Year - birthDate.Year;
      if (birthDate.Date > today.AddYears(-age)) age--;
      return age;
    }
  }
}