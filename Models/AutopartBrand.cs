using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
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
    
    [JsonIgnore]
    public virtual ICollection<Autopart> Autoparts { get; set; }
  }
}