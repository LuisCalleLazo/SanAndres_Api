using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class AutopartOfSellerService : IAutopartOfSellerService
  {
    private readonly IMapper _mapper;
    private readonly ITRepository _repo;

    public AutopartOfSellerService(IMapper mapper, ITRepository repo)
    {
      _mapper = mapper;
      _repo = repo;
    }


    public async Task<AutopartOfSellerDto> CreateAutopartOfSeller(AutopartOfSellerToCreateDto create, int sellerId)
    {
      var autopart = _mapper.Map<AutopartOfSeller>(create);
      autopart.SellerId = sellerId;
      await _repo.Create(autopart);

      return _mapper.Map<AutopartOfSellerDto>(autopart);
    }

    public async Task<List<AutopartOfSellerDto>> GetAutopartOfSeller(int sellerId)
    {
      var list = await _repo.GetQueryable<AutopartOfSeller>()
        .Include(x => x.Autopart)
      .Where(x => x.SellerId == sellerId)
      .ToListAsync();
      return _mapper.Map<List<AutopartOfSellerDto>>(list);
    }

    public async Task<AutopartOfSellerDto> UpdateAutopartOfSeller(AutopartOfSellerToUpdateDto update, int id)
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