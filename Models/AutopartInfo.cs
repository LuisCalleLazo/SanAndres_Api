using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("autopart_info")]
  public class AutopartInfo : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string Value { get; set; }
    public int TypeId { get; set; }
    public int AutopartId { get; set; }

    public virtual AutopartTypeInfo AutopartTypeInfo { get; set; }
    public virtual Autopart Autopart { get; set; }
  }
}