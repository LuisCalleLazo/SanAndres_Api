using SanAndres_Api.Models.Templeates;

namespace SanAndres_Api.Models
{
  public class AutopartTypeInfo : HistorymModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public AutopartTypeInfoEnum TypeValue { get; set; }
  }

  public enum AutopartTypeInfoEnum
  {
    Text, Number, XforXforX
  }
}