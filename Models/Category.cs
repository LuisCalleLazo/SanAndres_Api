using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("category")]
  public class Category : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Asset { get; set; }

    [JsonIgnore]
    public virtual ICollection<Autopart> Autoparts { get; set; }
  }
}