using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("city")]
  public class City : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Photo { get; set; }
    public int CountryId { get; set; }

    public virtual Country Country { get; set; }
    public virtual ICollection<UserInfo> UserInfos { get; set; }
  }
}