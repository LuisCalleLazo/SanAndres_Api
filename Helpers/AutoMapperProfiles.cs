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
      CreateMap<Autopart, AutopartDetailDto>();
      CreateMap<AuthRegisterDto, UserInfo>();
      CreateMap<AutopartOfSeller, AutopartOfSellerDto>();
      CreateMap<AutopartOfSellerDto, AutopartOfSeller>();
      CreateMap<AutopartOfSellerToCreateDto, AutopartOfSeller>();
      CreateMap<AutopartToCreateDto, Autopart>();

      CreateMap<AutopartBrand, AutopartBrandToListDto>();
      CreateMap<AutopartBrandToCreate, AutopartBrand>();
      CreateMap<Category, AutopartCategoryToListDto>();
      CreateMap<AutopartInfoToCreate, AutopartInfo>();
      CreateMap<AutopartInfo, AutopartInfoDto>();
      CreateMap<AutopartAssetToCreate, AutopartAsset>();
      CreateMap<AutopartTypeInfo, AutopartInfoTypeDto>();
      CreateMap<AutopartInfoTypeToCreateDto, AutopartTypeInfo>();


      CreateMap<SaleDetailToCreateDto, SaleDetail>()
          .ForMember(dest => dest.Sales, opt => opt.Ignore());
      CreateMap<SaleToCreateDto, Sale>();
      CreateMap<SaleToAddDto, Sale>();
      CreateMap<Sale, SaleDto>();

      CreateMap<AuthResponseDto, Token>()
      .ForMember(dest => dest.UserId, opt => opt.Ignore())
      .ForMember(dest => dest.User, opt => opt.Ignore());

      CreateMap<CustomerToCreateDto, CustomerOfSeller>();
      CreateMap<CustomerToUpdateDto, CustomerOfSeller>();
      CreateMap<CustomerOfSeller, CustomerToDetailDto>();
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