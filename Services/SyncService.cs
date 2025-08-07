using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class SyncService : ISyncService
  {
    private readonly ITRepository _repo;
    private readonly IMapper _mapper;
    public SyncService(ITRepository repo, IMapper mapper)
    {
      _repo = repo;
      _mapper = mapper;
    }

    public async Task<List<AutopartOfSellerDto>> SyncAutopartsOfSeller(int sellerId, List<AutopartOfSellerDto> syncData)
    {
      var existingAutoparts = await _repo.GetQueryable<AutopartOfSeller>()
           .Where(x => x.SellerId == sellerId)
           .ToListAsync();

      foreach (var dto in syncData)
      {
        var existing = existingAutoparts.FirstOrDefault(x =>
            x.AutopartId == dto.AutopartId && x.SellerId == sellerId);

        if (existing != null)
        {
          existing.AmountUnit = dto.AmountUnit;
          existing.AmountUnitPublic = dto.AmountUnitPublic;
          existing.UnitPrice = dto.UnitPrice;
          existing.UnitPricePublic = dto.UnitPricePublic;
          existing.WholessalePrice = dto.WholessalePrice;
          existing.WholessalePricePublic = dto.WholessalePricePublic;
          existing.DeleteAt = DateTime.MinValue;

          await _repo.Update(existing);
        }
        else
        {
          var newAutopart = _mapper.Map<AutopartOfSeller>(dto);
          newAutopart.SellerId = sellerId;

          await _repo.Create(newAutopart);
        }
      }

      var autopartsToDelete = existingAutoparts
              .Where(existing => !syncData.Any(dto => dto.AutopartId == existing.AutopartId))
              .ToList();

      foreach (var autopart in autopartsToDelete)
      {
        autopart.DeleteAt = DateTime.UtcNow;
        await _repo.Update(autopart);
      }

      var autopartsFinally = await _repo.GetQueryable<AutopartOfSeller>()
        .Where(x => x.SellerId == sellerId && x.DeleteAt == DateTime.MinValue)
        .ToListAsync();

      return _mapper.Map<List<AutopartOfSellerDto>>(autopartsFinally);
    }
  }
}