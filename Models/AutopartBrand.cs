using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("autopart_brand")]
  public class AutopartBrand : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
    
    public virtual ICollection<Autopart> Autoparts { get; set; }
  }
}