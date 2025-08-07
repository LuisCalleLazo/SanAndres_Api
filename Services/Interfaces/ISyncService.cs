using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface ISyncService
  {
    Task<List<AutopartOfSellerDto>> SyncAutopartsOfSeller(int sellerId, List<AutopartOfSellerSyncDto> syncData);
    Task<List<CustomerOfSellerDto>> SyncCustomerOfSeller(int sellerId, List<CustomerOfSellerSyncDto> syncData);
    Task<List<SaleDetailDto>> SyncSales(int sellerId, List<SaleDetailSyncDto> syncData);
    Task<List<AutopartToListDto>> SyncAutoparts(List<AutopartSyncDto> syncData);
  }
}