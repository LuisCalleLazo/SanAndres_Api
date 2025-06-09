using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("company")]
  public class Company : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Logo { get; set; }
    public int CountryId { get; set; }


    [JsonIgnore]
    public virtual ICollection<Seller> Sellers { get; set; }
    [JsonIgnore]
    public virtual ICollection<CompanyInfo> CompanyInfos { get; set; }
    
    public virtual Country Country { get; set; }
  }
}