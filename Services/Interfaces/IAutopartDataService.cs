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

    // CATEGORIES
    Task<List<AutopartCategoryToListDto>> GetCategories();
    Task<AutopartCategoryToListDto> CreateCategory(AutopartCategoryToCreate create);
    Task<AutopartCategoryToListDto> UpdateCategory(AutopartCategoryToCreate update, int id);
    Task<AutopartCategoryToListDto> DeleteCategory(int id);

    Task<List<AutopartInfoTypeDto>> GetAutopartInfoTypes();
    Task<AutopartInfoTypeDto> CreateAutopartInfoType(AutopartInfoTypeToCreateDto create);
    Task<AutopartInfoTypeDto> UpdateAutopartInfoType(AutopartInfoTypeToUpdateDto update, int id);
    Task<AutopartInfoTypeDto> DeleteAutopartTypeInfo(int id);


    Task<string> CreateAsset(AutopartAssetToCreate create);
    Task<AutopartInfoDto> CreateInfo(AutopartInfoToCreate create);
    Task DeleteInfo(int id);
    Task DeleteAsset(int id);
  }
}