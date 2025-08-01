using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface ISearchAutopartService
  {
    Task<List<AutopartToListDto>> SearchAutopartsByFilter(AutopartFilterDto filter);
  }
}