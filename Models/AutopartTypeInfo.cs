using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("autopart_type_info")]
  public class AutopartTypeInfo : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public AutopartTypeInfoEnum TypeValue { get; set; }


    [JsonIgnore]
    public virtual ICollection<AutopartInfo> AutopartInfos { get; set; }
  }

  public enum AutopartTypeInfoEnum
  {
    Code, Measures, Contains 
  }
}