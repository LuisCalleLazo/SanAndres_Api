using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface ICustomerOfSellerService
  {
    Task<List<CustomerToDetailDto>> GetListBySeller(int sellerId);
    Task<CustomerToDetailDto> Create(CustomerToCreateDto create, int sellerId);
    Task<CustomerToDetailDto> Update(CustomerToUpdateDto update, int customerId, int sellerId);
    Task<CustomerToDetailDto> Delete(int customerId);
  }
}