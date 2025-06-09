using SanAndres_Api.Models;

namespace SanAndres_Api.Dtos
{
  public class SaleDetailToListDto
  {
    public int Id { get; set; }
    public int? CustomerId { get; set; }
    public string CustomerNotSubscribed { get; set; }
    public int SellerId { get; set; }
    public DateTime SaleDate { get; set; }
    public SaleState State { get; set; }
    public List<SaleToListDto> Items { get; set; }
  }

  public class SaleToListDto
  {
    public int Id { get; set; }
    public string AutopartName { get; set; }
    public string AutopartAsset { get; set; }
    public int SaleDetailId { get; set; }
    
    public int Amount { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal WholessalePrice { get; set; }
  }
}