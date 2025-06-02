using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("autopart")]
  public class Autopart : AuditModel
  {
    [Key]
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int CategoryId { get; set; }

    // public virtual ICollection<AutopartInfo> AutopartInfos { get; set; }
    // public virtual ICollection<AutopartAsset> AutopartAssets { get; set; }
    // public virtual ICollection<AutopartOfSeller> AutopartOfSellers { get; set; }
    // public virtual ICollection<Sale> Sales { get; set; }

    // public virtual AutopartBrand AutopartBrand { get; set; }
    // public virtual Category Category { get; set; }
  }
}