using SanAndres_Api.Models;

namespace SanAndres_Api.Dtos
{

  public class SaleDetailToCreateDto
  {
    public int? CustomerId { get; set; }
    public string CustomerNotSubscribed { get; set; }
    public int SellerId { get; set; }
    public DateTime SaleDate { get; set; }
    public SaleState State { get; set; }
    public List<SaleToCreateDto> Items { get; set; }
  }

  public class SaleToCreateDto
  {
    public int AutopartId { get; set; }
    public int Amount { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal WholessalePrice { get; set; }
  }

  public class SaleToAddDto : SaleToCreateDto
  {
    public int SaleDetailId { get; set; }
  }
}