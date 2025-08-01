using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface ISaleService
  {
    Task<List<SaleDetailDto>> GetList(int sellerId);
    Task<List<SaleDto>> GetSaleItems(int saleDetailId);
    Task CreateSale(SaleDetailToCreateDto create);
    Task<SaleDto> CreateSaleItem(SaleToAddDto create);
    Task UpdateSale(SaleDetailToUpdateDto update, int id);
    Task UpdateSaleItem(SaleToUpdateDto update, int id);
    Task DeleteSale(int id);
    Task DeleteSaleItem(int id);
  }
}