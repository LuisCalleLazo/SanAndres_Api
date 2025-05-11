using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("autopart_asset")]
  public class AutopartAsset : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string Asset { get; set; }
    public string Description { get; set; }
    public int AutopartId { get; set; }

    public virtual Autopart Autopart { get; set; }
  }
}