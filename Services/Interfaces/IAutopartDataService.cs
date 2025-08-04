using SanAndres_Api.Dtos;

namespace SanAndres_Api.Services.Interfaces
{
  public interface IAutopartDataService
  {
    // BRANDS
    Task<List<AutopartBrandToListDto>> GetBrands();
    Task<AutopartBrandToListDto> CreateAutopartBrand(AutopartBrandToCreate create);
    Task<AutopartBrandToListDto> DeleteAutopartBrand(int id);
    Task<AutopartBrandToListDto> UpdateAutopartBrand(AutopartBrandToUpdate update, int id);


    Task<List<AutopartCategoryToListDto>> GetCategories();
    Task<string> CreateAsset(AutopartAssetToCreate create);
    Task<AutopartInfoDto> CreateInfo(AutopartInfoToCreate create);
    Task DeleteInfo(int id);
    Task DeleteAsset(int id);
  }
}