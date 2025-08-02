using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface ISyncService
  {
    Task<List<AutopartOfSellerDto>> SyncAutopartsOfSeller(int sellerId, List<AutopartOfSellerDto> syncData);
  }
}