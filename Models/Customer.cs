using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("customer")]
  public class Customer : HistorymModel
  {
    [Key]
    public int Id { get; set; }
    public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    public virtual User User { get; set; }
  }
}