using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("sale_detail")]
  public class SaleDetail : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public int? CustomerId { get; set; }
    public string CustomerNotSubscribed { get; set; }
    public int SellerId { get; set; }
    public DateTime SaleDate { get; set; }
    public SaleState State { get; set; }


    public virtual ICollection<Sale> Sales { get; set; }

    public virtual Customer Customer { get; set; }
    public virtual Seller Seller { get; set; }
  }

  public enum SaleState
  {
    Nothing, Canceled, PayNotTotal
  }
}