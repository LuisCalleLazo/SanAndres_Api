using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("customer")]
  public class Customer : AuditModel
  {
    [Key]
    public int Id { get; set; }
    [JsonIgnore]
    public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    public virtual User User { get; set; }
  }
}