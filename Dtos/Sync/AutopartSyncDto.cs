using SanAndres_Api.Models;

namespace SanAndres_Api.Dtos
{
  public class AutopartSyncDto
  {
    public int? RefId { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public int BrandId { get; set; }
    public List<AutopartInfoSyncDto> Infos { get; set; }
    public List<AutopartAssetSyncDto> Assets { get; set; }
  }

  public class AutopartInfoSyncDto
  {
    public int? RefId { get; set; }
    public string Value { get; set; }
    public int TypeId { get; set; }
    public AutopartTypeInfoEnum Type { get; set; }
  }

  public class AutopartAssetSyncDto
  {
    public int? RefId { get; set; }
    public IFormFile Asset { get; set; }
    public string Description { get; set; }
  }
}