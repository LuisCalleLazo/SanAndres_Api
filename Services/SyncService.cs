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

    public async Task<List<AutopartOfSellerDto>> SyncAutopartsOfSeller(int sellerId, List<AutopartOfSellerSyncDto> syncData)
    {
      var existingAutoparts = await _repo.GetQueryable<AutopartOfSeller>()
           .Where(x => x.SellerId == sellerId)
           .ToListAsync();

      foreach (var dto in syncData)
      {
        var existing = existingAutoparts.FirstOrDefault(x => x.Id == dto?.RefId);

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
              .Where(existing => !syncData.Any(dto => dto.RefId == existing.Id))
              .ToList();

      foreach (var autopart in autopartsToDelete)
      {
        autopart.DeleteAt = DateTime.UtcNow;
        autopart.DeleteUserId = sellerId;
        await _repo.Update(autopart);
      }

      var autopartsFinally = await _repo.GetQueryable<AutopartOfSeller>()
        .Where(x => x.SellerId == sellerId && x.DeleteAt == DateTime.MinValue)
        .ToListAsync();

      return _mapper.Map<List<AutopartOfSellerDto>>(autopartsFinally);
    }


    public async Task<List<CustomerOfSellerDto>> SyncCustomerOfSeller(int sellerId, List<CustomerOfSellerSyncDto> syncData)
    {
      var existingCustomers = await _repo.GetQueryable<CustomerOfSeller>()
      .Where(x => x.SellerId == sellerId)
      .ToListAsync();

      foreach (var dto in syncData)
      {
        var existing = existingCustomers.FirstOrDefault(x => x.Id == dto?.RefId);

        if (existing != null)
        {
          existing.SellerId = sellerId;
          existing.Name = dto.Name;
          existing.Email = dto.Email;
          existing.Phone = dto.Phone;
          await _repo.Update(existing);
        }
        else
        {
          var newCustomer = _mapper.Map<CustomerOfSeller>(dto);
          newCustomer.SellerId = sellerId;

          await _repo.Create(newCustomer);
        }
      }

      var customersToDelete = existingCustomers
              .Where(existing => !syncData.Any(dto => dto.RefId == existing.Id))
              .ToList();

      foreach (var customer in customersToDelete)
      {
        customer.DeleteAt = DateTime.UtcNow;
        customer.DeleteUserId = sellerId;
        await _repo.Update(customer);
      }

      var customersFinally = await _repo.GetQueryable<CustomerOfSeller>()
        .Where(x => x.SellerId == sellerId && x.DeleteAt == DateTime.MinValue)
        .ToListAsync();

      return _mapper.Map<List<CustomerOfSellerDto>>(customersFinally);
    }
  }
}