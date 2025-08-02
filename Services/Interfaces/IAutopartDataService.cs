using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface IAutopartDataService
  {
    Task<List<AutopartBrandToListDto>> GetBrands();
    Task<List<AutopartCategoryToListDto>> GetCategories();
    Task<string> CreateAsset(AutopartAssetToCreate create);
    Task<AutopartInfoDto> CreateInfo(AutopartInfoToCreate create);
    Task DeleteInfo(int id);
    Task DeleteAsset(int id);
  }
}