using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("seller")]
  public class Seller : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public int CompanyId { get; set; }

    public virtual ICollection<AutopartOfSeller> AutopartOfSellers { get; set; }
    public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    public virtual User User { get; set; }
    public virtual Company Company { get; set; }
  }
}