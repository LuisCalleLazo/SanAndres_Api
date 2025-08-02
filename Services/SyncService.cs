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
        // Buscar si ya existe esta autoparte para este vendedor
        var existing = existingAutoparts.FirstOrDefault(x =>
            x.AutopartId == dto.AutopartId && x.SellerId == sellerId);

        if (existing != null)
        {
          // Actualizar registro existente
          existing.AmountUnit = dto.AmountUnit;
          existing.AmountUnitPublic = dto.AmountUnitPublic;
          existing.UnitPrice = dto.UnitPrice;
          existing.UnitPricePublic = dto.UnitPricePublic;
          existing.WholessalePrice = dto.WholessalePrice;
          existing.WholessalePricePublic = dto.WholessalePricePublic;

          await _repo.Update(existing);
        }
        else
        {
          // Crear nuevo registro
          var newAutopart = new AutopartOfSeller
          {
            AutopartId = dto.AutopartId,
            SellerId = sellerId,
            AmountUnit = dto.AmountUnit,
            AmountUnitPublic = dto.AmountUnitPublic,
            UnitPrice = dto.UnitPrice,
            UnitPricePublic = dto.UnitPricePublic,
            WholessalePrice = dto.WholessalePrice,
            WholessalePricePublic = dto.WholessalePricePublic
          };

          await _repo.Create(newAutopart);
        }
      }

      var autopartsFinally = await _repo.GetQueryable<AutopartOfSeller>()
        .Where(x => x.SellerId == sellerId).ToListAsync();


      return _mapper.Map<List<AutopartOfSellerDto>>(autopartsFinally);
    }
  }
}