using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface IAutopartService
  {
    Task<List<AutopartToListDto>> GetAutoparts();
    Task<AutopartDetailDto> CreateAutopart(AutopartToCreateDto create);
    Task<AutopartOfSellerDto> CreateAutopartOfSeller(AutopartOfSellerToCreateDto create, int sellerId);
    Task<List<AutopartOfSellerDto>> GetAutopartOfSeller();
    Task<AutopartOfSellerDto> UpdateAutopart(AutopartOfSellerToUpdateDto update, int id);
    Task DeleteAutopartOfSeller(int id);
  }
}