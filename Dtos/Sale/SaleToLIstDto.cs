using SanAndres_Api.Models;

namespace SanAndres_Api.Dtos
{
  public class SaleDetailDto
  {
    public int Id { get; set; }
    public int? CustomerId { get; set; }
    public string CustomerNotSubscribed { get; set; }
    public int SellerId { get; set; }
    public DateTime SaleDate { get; set; }
    public SaleState State { get; set; }
    public decimal TotalPrice { get; set; }
  }



  public class SaleDto
  {
    public int Id { get; set; }
    public string AutopartName { get; set; }
    public string AutopartAsset { get; set; }
    public int Amount { get; set; }
    public decimal Price { get; set; }
  }
}