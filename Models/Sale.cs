using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("sale")]
  public class Sale : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public int AutopartId { get; set; }
    public int SaleDetailId { get; set; }

    public int Amount { get; set; }
    public decimal Price { get; set; }

    public virtual Autopart Autopart { get; set; }
    public virtual SaleDetail SaleDetail { get; set; }
  }
}