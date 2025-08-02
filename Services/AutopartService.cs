using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class AutopartService : IAutopartService
  {
    private readonly IMapper _mapper;
    private readonly ITRepository _repo;
    public AutopartService(ITRepository repo, IMapper mapper)
    {
      _repo = repo;
      _mapper = mapper;
    }


    public async Task<List<AutopartToListDto>> GetAutoparts()
    {
      var list = await _repo.GetQueryable<Autopart>()
          .Include(x => x.AutopartAssets)
          .Include(x => x.AutopartInfos)
              .ThenInclude(i => i.AutopartTypeInfo)
          .Include(x => x.AutopartBrand)
          .Include(x => x.Category)
          .Select(x => new AutopartToListDto
          {
            Id = x.Id,
            Name = x.Name,
            BrandId = x.AutopartBrand.Id,
            BrandName = x.AutopartBrand.Name,
            CategoryId = x.Category.Id,
            CategoryName = x.Category.Name,
            Infos = x.AutopartInfos.Select(info => new AutopartInfoDto
            {
              Id = info.Id,
              Value = info.Value,
              TypeId = info.TypeId,
              TypeName = info.AutopartTypeInfo.Name
            }).ToList(),
            Assets = x.AutopartAssets.Select(asset => new AutopartAssetDto
            {
              Id = asset.Id,
              Asset = asset.Asset,
              Description = asset.Description
            }).ToList()
          })
          .ToListAsync();

      return list;
    }

    public async Task<AutopartDetailDto> CreateAutopart(AutopartToCreateDto create)
    {
      var created = _mapper.Map<Autopart>(create);
      await _repo.Create(created);

      return _mapper.Map<AutopartDetailDto>(created);
    }

    public async Task<AutopartOfSellerDto> CreateAutopartOfSeller(AutopartOfSellerToCreateDto create, int sellerId)
    {
      var autopart = _mapper.Map<AutopartOfSeller>(create);
      autopart.SellerId = sellerId;
      await _repo.Create(autopart);

      return _mapper.Map<AutopartOfSellerDto>(autopart);
    }

    public async Task<List<AutopartOfSellerDto>> GetAutopartOfSeller()
    {
      var list = await _repo.GetQueryable<AutopartOfSeller>()
        .Include(x => x.Autopart)
      .ToListAsync();
      return _mapper.Map<List<AutopartOfSellerDto>>(list);
    }

    public async Task<AutopartOfSellerDto> UpdateAutopart(AutopartOfSellerToUpdateDto update, int id)
    {
      var autopart = await _repo.GetById<AutopartOfSeller>(id);

      if (update.AmountUnit != null)
        autopart.AmountUnit = (int)update.AmountUnit;

      if (update.AmountUnitPublic != null)
        autopart.AmountUnitPublic = (int)update.AmountUnitPublic;

      if (update.UnitPrice != null)
        autopart.UnitPrice = (decimal)update.UnitPrice;

      if (update.UnitPricePublic != null)
        autopart.UnitPricePublic = (decimal)update.UnitPricePublic;

      if (update.WholessalePrice != null)
        autopart.WholessalePrice = (decimal)update.WholessalePrice;

      if (update.WholessalePricePublic != null)
        autopart.WholessalePricePublic = (decimal)update.WholessalePricePublic;

      await _repo.Update(autopart);

      return _mapper.Map<AutopartOfSellerDto>(autopart);
    }

    public async Task DeleteAutopartOfSeller(int id)
    {
      var autopart = await _repo.GetById<AutopartOfSeller>(id);
      await _repo.Remove(autopart);
    }

  }
}