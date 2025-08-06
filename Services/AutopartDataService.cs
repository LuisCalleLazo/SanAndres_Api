using AutoMapper;
using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class AutopartDataService : IAutopartDataService
  {
    private readonly IMapper _mapper;
    private readonly ITRepository _repo;
    private readonly ICloudinaryService _cloudinary;
    public AutopartDataService(IMapper mapper, ITRepository repo, ICloudinaryService cloudinary)
    {
      _mapper = mapper;
      _repo = repo;
      _cloudinary = cloudinary;
    }

    public async Task<List<AutopartBrandToListDto>> GetBrands() =>
      _mapper.Map<List<AutopartBrandToListDto>>(
        await _repo.GetQueryable<AutopartBrand>()
        .Where(x => x.DeleteAt == DateTime.MinValue)
        .ToListAsync());

    public async Task<AutopartBrandToListDto> CreateAutopartBrand(AutopartBrandToCreate create)
    {
      string path_asset = _cloudinary.UploadFile(create.Logo, $"SanAndres/Brand");
      var brand = _mapper.Map<AutopartBrand>(create);
      brand.Logo = path_asset;

      await _repo.Create(brand);

      return _mapper.Map<AutopartBrandToListDto>(brand);
    }

    public async Task<AutopartBrandToListDto> DeleteAutopartBrand(int id)
    {
      var brand = await _repo.GetById<AutopartBrand>(id);
      brand.DeleteAt = DateTime.UtcNow;

      await _repo.Update(brand);
      return _mapper.Map<AutopartBrandToListDto>(brand);
    }

    public async Task<AutopartBrandToListDto> UpdateAutopartBrand(AutopartBrandToUpdate update, int id)
    {
      var brand = await _repo.GetById<AutopartBrand>(id);

      if (update.Logo != null)
      {
        string path_asset = _cloudinary.UploadFile(update.Logo, $"SanAndres/Brand");
        brand.Logo = path_asset;
      }

      if (update.Name != null)
        brand.Name = update.Name;

      brand.UpdateAt = DateTime.UtcNow;

      await _repo.Update(brand);
      return _mapper.Map<AutopartBrandToListDto>(brand);
    }


    public async Task<List<AutopartCategoryToListDto>> GetCategories() =>
      _mapper.Map<List<AutopartCategoryToListDto>>(
        await _repo.GetQueryable<Category>()
        .Where(x => x.DeleteAt == DateTime.MinValue)
        .ToListAsync()
      );

    public async Task<AutopartCategoryToListDto> CreateCategory(AutopartCategoryToCreate create)
    {
      var category = _mapper.Map<Category>(create);
      await _repo.Create(category);
      return _mapper.Map<AutopartCategoryToListDto>(category);
    }

    public async Task<AutopartCategoryToListDto> UpdateCategory(AutopartCategoryToCreate update, int id)
    {
      var category = await _repo.GetById<Category>(id);
      if (update.Name != null)
        category.Name = update.Name;

      if (update.Description != null)
        category.Description = update.Description;


      category.UpdateAt = DateTime.UtcNow;
      await _repo.Update(category);
      return _mapper.Map<AutopartCategoryToListDto>(category);
    }

    public async Task<AutopartCategoryToListDto> DeleteCategory(int id)
    {
      var category = await _repo.GetById<Category>(id);
      category.DeleteAt = DateTime.UtcNow;
      await _repo.Update(category);
      return _mapper.Map<AutopartCategoryToListDto>(category);
    }

    public async Task<string> CreateAsset(AutopartAssetToCreate create)
    {

      string path_asset = _cloudinary.UploadFile(create.Asset, $"SanAndres/Assets");
      var newAsset = _mapper.Map<AutopartAsset>(create);
      newAsset.Asset = path_asset;
      await _repo.Create(newAsset);

      return path_asset;
    }
    public async Task<List<AutopartInfoTypeDto>> GetAutopartInfoTypes() =>
      _mapper.Map<List<AutopartInfoTypeDto>>(
        await _repo.GetQueryable<AutopartTypeInfo>()
        .Where(x => x.DeleteAt == DateTime.MinValue)
        .ToListAsync());

    public async Task<AutopartInfoTypeDto> CreateAutopartInfoType(AutopartInfoTypeToCreateDto create)
    {
      var created = _mapper.Map<AutopartTypeInfo>(create);
      await _repo.Create(created);
      return _mapper.Map<AutopartInfoTypeDto>(created);
    }

    public async Task<AutopartInfoTypeDto> UpdateAutopartInfoType(AutopartInfoTypeToUpdateDto update, int id)
    {
      var type = await _repo.GetById<AutopartTypeInfo>(id);

      if (update.Name != null)
        type.Name = update.Name;

      if (update.Description != null)
        type.Description = update.Description;

      if (update.TypeValue != null)
        type.TypeValue = (AutopartTypeInfoEnum)update.TypeValue;

      await _repo.Update(type);

      return _mapper.Map<AutopartInfoTypeDto>(type);
    }

    public async Task<AutopartInfoTypeDto> DeleteAutopartTypeInfo(int id)
    {
      var type = await _repo.GetById<AutopartTypeInfo>(id);
      type.DeleteAt = DateTime.UtcNow;
      await _repo.Update(type);
      return _mapper.Map<AutopartInfoTypeDto>(type);
    }
    public async Task<AutopartInfoDto> CreateInfo(AutopartInfoToCreate create)
    {
      var newInfo = _mapper.Map<AutopartInfo>(create);
      await _repo.Create(newInfo);

      return _mapper.Map<AutopartInfoDto>(newInfo);
    }

    public async Task DeleteInfo(int id)
    {
      var info = await _repo.GetById<AutopartInfo>(id);
      info.DeleteAt = DateTime.UtcNow;
      await _repo.Update(info);
    }

    public async Task DeleteAsset(int id)
    {
      var info = await _repo.GetById<AutopartAsset>(id);
      await _repo.Remove(info);
    }
  }
}