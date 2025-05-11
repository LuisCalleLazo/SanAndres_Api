using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("country")]
  public class Country : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Photo { get; set; }
    public string CodePhone { get; set; }
    
    public virtual ICollection<Company> Companies { get; set; }
    public virtual ICollection<City> Cities { get; set; }
  }
}