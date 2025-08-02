using AutoMapper;
using CloudinaryDotNet.Actions;
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

    public async Task<List<AutopartBrandToListDto>> GetBrands() => _mapper.Map<List<AutopartBrandToListDto>>(await _repo.GetAll<AutopartBrand>());
    public async Task<List<AutopartCategoryToListDto>> GetCategories() => _mapper.Map<List<AutopartCategoryToListDto>>(await _repo.GetAll<Category>());

    public async Task<string> CreateAsset(AutopartAssetToCreate create)
    {

      string path_asset = _cloudinary.UploadFile(create.Asset, $"SanAndres/Assets");
      var newAsset = _mapper.Map<AutopartAsset>(create);
      newAsset.Asset = path_asset;
      await _repo.Create(newAsset);

      return path_asset;
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
      await _repo.Remove(info);
    }
    
    public async Task DeleteAsset(int id)
    {
      var info = await _repo.GetById<AutopartAsset>(id);
      await _repo.Remove(info);
    }
  }
}