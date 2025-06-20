using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("user")]
  public class User : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Guid PasswordSalt { get; set; }

    // 
    public virtual Admin Admin { get; set; }
    public virtual UserInfo UserInfo { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual Seller Seller { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Token> Tokens { get; set; }
  }
}