using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface IAutopartOfSellerService
  {
    Task<AutopartOfSellerDto> CreateAutopartOfSeller(AutopartOfSellerToCreateDto create, int sellerId);
    Task<List<AutopartOfSellerDto>> GetAutopartOfSeller(int sellerId);
    Task<AutopartOfSellerDto> UpdateAutopartOfSeller(AutopartOfSellerToUpdateDto update, int id);
    Task DeleteAutopartOfSeller(int id);
  }
}