using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("user_info")]
  public class UserInfo : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string DadFirstName { get; set; }
    public string MomFirstName { get; set; }
    public string DadLastName { get; set; }
    public string MomLastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Adress { get; set; }
    public string Ci { get; set; }
    public int CityId { get; set; }

    public virtual City City { get; set; }
    public virtual User User { get; set; }
  }
}