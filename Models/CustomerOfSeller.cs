using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  public class CustomerOfSeller : AuditModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int SellerId { get; set; }
    public virtual Seller Seller { get; set; }
  }
}