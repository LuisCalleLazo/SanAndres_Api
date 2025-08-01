using SanAndres_Api.Models;

namespace SanAndres_Api.Dtos
{
  public class SaleDetailToUpdateDto
  {
    public int? CustomerId { get; set; }
    public string CustomerNotSubscribed { get; set; }
    public int? SellerId { get; set; }
    public DateTime? SaleDate { get; set; }
    public SaleState? State { get; set; }
  }
  
  public class SaleToUpdateDto
  {
    public int? AutopartId { get; set; }
    public int? Amount { get; set; }
    public decimal? Price { get; set; }
  }
}