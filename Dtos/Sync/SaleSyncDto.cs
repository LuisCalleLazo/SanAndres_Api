using SanAndres_Api.Models;

namespace SanAndres_Api.Dtos
{
  public class SaleDetailSyncDto
  {
    public int? RefId { get; set; }
    public int? CustomerId { get; set; }
    public string CustomerNotSubscribed { get; set; }
    public DateTime SaleDate { get; set; }
    public SaleState State { get; set; }
    public List<SaleSyncDto> Sales { get; set; }
  }

  public class SaleSyncDto
  {
    public int? RefId { get; set; }
    public int AutopartId { get; set; }
    public int Amount { get; set; }
    public decimal Price { get; set; }
  }
}