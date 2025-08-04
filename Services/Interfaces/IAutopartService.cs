using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface IAutopartService
  {
    Task<List<AutopartToListDto>> GetAutoparts();
    Task<AutopartDetailDto> CreateAutopart(AutopartToCreateDto create);
  }
}