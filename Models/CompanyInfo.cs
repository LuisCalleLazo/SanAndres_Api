using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("company_info")]
  public class CompanyInfo : HistorymModel
  {
    [Key]
    public int Id { get; set; }
    public CompanyInfoType Type { get; set; }
    public string ValueInfo { get; set; }
    public string Description { get; set; }
    public virtual Company Companies { get; set; }
  }

  
  public enum CompanyInfoType
  {
    Phone, Email, 
  }
}