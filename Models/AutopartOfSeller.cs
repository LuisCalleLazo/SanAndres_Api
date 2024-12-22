using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  [Table("autopart_of_seller")]
  public class AutopartOfSeller : HistorymModel
  {
    [Key]
    public int Id { get; set; }
    public int AutopartId { get; set; }
    public int SellerId { get; set; }

    public int AmountUnit { get; set; }
    public int AmountUnitPublic { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal UnitPricePublic { get; set; }
    public decimal WholessalePrice { get; set; }
    public decimal WholessalePricePublic { get; set; }

    public virtual Autopart Autopart { get; set; }
    public virtual Seller Seller { get; set; }
  }
}