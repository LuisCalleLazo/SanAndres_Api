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
    private readonly ISaleService _saleService;
    private readonly IAutopartService _autopartService;
    private readonly ICloudinaryService _cloudinary;
    public SyncService(ITRepository repo, IMapper mapper, ISaleService saleService, IAutopartService autopartService, ICloudinaryService cloudinary)
    {
      _repo = repo;
      _mapper = mapper;
      _saleService = saleService;
      _autopartService = autopartService;
      _cloudinary = cloudinary;
    }

    public async Task<List<AutopartOfSellerDto>> SyncAutopartsOfSeller(int sellerId, List<AutopartOfSellerSyncDto> syncData)
    {
      var existingAutoparts = await _repo.GetQueryable<AutopartOfSeller>()
           .Where(x => x.SellerId == sellerId && x.DeleteAt == DateTime.MinValue)
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
      .Where(x => x.SellerId == sellerId && x.DeleteAt == DateTime.MinValue)
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

    public async Task<List<SaleDetailDto>> SyncSales(int sellerId, List<SaleDetailSyncDto> syncData)
    {
      var existingSales = await GetExistingSales(sellerId);

      await ProcessSalesSync(sellerId, syncData, existingSales);
      await ProcessDeletedSales(sellerId, syncData, existingSales);

      return await _saleService.GetList(sellerId);
    }

    private async Task<List<SaleDetail>> GetExistingSales(int sellerId)
    {
      return await _repo.GetQueryable<SaleDetail>()
          .Where(x => x.SellerId == sellerId && x.DeleteAt == DateTime.MinValue)
          .Include(x => x.Sales)
          .ToListAsync();
    }

    private async Task ProcessSalesSync(int sellerId, List<SaleDetailSyncDto> syncData, List<SaleDetail> existingSales)
    {
      var salesToUpdate = new List<SaleDetail>();
      var salesToCreate = new List<SaleDetail>();
      var itemsToSync = new List<(List<SaleSyncDto> items, int saleDetailId)>();

      foreach (var dto in syncData)
      {
        var existing = existingSales.FirstOrDefault(x => x.Id == dto?.RefId);

        if (existing != null)
        {
          UpdateExistingSale(existing, dto, sellerId);
          salesToUpdate.Add(existing);
          itemsToSync.Add((dto.Sales, existing.Id));
        }
        else
        {
          var newSale = CreateNewSale(dto, sellerId);
          salesToCreate.Add(newSale);
          itemsToSync.Add((dto.Sales, newSale.Id));
        }
      }

      if (salesToUpdate.Any()) await _repo.UpdateRange(salesToUpdate);
      if (salesToCreate.Any()) await _repo.CreateRange(salesToCreate);

      var syncTasks = itemsToSync.Select(x => SyncSaleItemsBatch(x.items, x.saleDetailId, sellerId));
      await Task.WhenAll(syncTasks);
    }

    private async Task ProcessDeletedSales(int sellerId, List<SaleDetailSyncDto> syncData, List<SaleDetail> existingSales)
    {
      var salesToDelete = existingSales
          .Where(existing => !syncData.Any(dto => dto.RefId == existing.Id))
          .ToList();

      if (!salesToDelete.Any()) return;

      foreach (var sale in salesToDelete)
      {
        sale.DeleteAt = DateTime.UtcNow;
        sale.DeleteUserId = sellerId;
      }

      await _repo.UpdateRange(salesToDelete);

      var saleIdsToDelete = salesToDelete.Select(x => x.Id).ToList();
      await MarkSaleItemsAsDeleted(saleIdsToDelete, sellerId);
    }

    private void UpdateExistingSale(SaleDetail existing, SaleDetailSyncDto dto, int sellerId)
    {
      existing.SellerId = sellerId;
      existing.CustomerId = dto.CustomerId;
      existing.CustomerNotSubscribed = dto.CustomerNotSubscribed;
      existing.SaleDate = dto.SaleDate;
      existing.State = dto.State;
    }

    private SaleDetail CreateNewSale(SaleDetailSyncDto dto, int sellerId)
    {
      var newSale = _mapper.Map<SaleDetail>(dto);
      newSale.SellerId = sellerId;
      return newSale;
    }

    private async Task SyncSaleItemsBatch(List<SaleSyncDto> syncData, int saleDetailId, int sellerId)
    {
      var existingItems = await _repo.GetQueryable<Sale>()
          .Where(x => x.SaleDetailId == saleDetailId)
          .ToListAsync();

      var itemsToUpdate = new List<Sale>();
      var itemsToCreate = new List<Sale>();
      var now = DateTime.UtcNow;

      foreach (var dto in syncData)
      {
        var existing = existingItems.FirstOrDefault(x => x.Id == dto?.RefId);

        if (existing != null)
        {
          existing.AutopartId = dto.AutopartId;
          existing.Amount = dto.Amount;
          existing.Price = dto.Price;
          itemsToUpdate.Add(existing);
        }
        else
        {
          var newSale = _mapper.Map<Sale>(dto);
          newSale.SaleDetailId = saleDetailId;
          itemsToCreate.Add(newSale);
        }
      }

      if (itemsToUpdate.Any()) await _repo.UpdateRange(itemsToUpdate);
      if (itemsToCreate.Any()) await _repo.CreateRange(itemsToCreate);

      // Procesar eliminaciones
      var itemsToDelete = existingItems
          .Where(existing => !syncData.Any(dto => dto.RefId == existing.Id))
          .ToList();

      if (itemsToDelete.Any())
      {
        foreach (var item in itemsToDelete)
        {
          item.DeleteAt = now;
          item.DeleteUserId = sellerId;
        }
        await _repo.UpdateRange(itemsToDelete);
      }
    }

    private async Task MarkSaleItemsAsDeleted(List<int> saleDetailIds, int sellerId)
    {
      var itemsToDelete = await _repo.GetQueryable<Sale>()
          .Where(x => saleDetailIds.Contains(x.SaleDetailId))
          .ToListAsync();

      if (!itemsToDelete.Any()) return;

      foreach (var item in itemsToDelete)
      {
        item.DeleteAt = DateTime.UtcNow;
        item.DeleteUserId = sellerId;
      }

      await _repo.UpdateRange(itemsToDelete);
    }

    public async Task<List<AutopartToListDto>> SyncAutoparts(List<AutopartSyncDto> syncData)
    {
      var existingAutoparts = await _repo.GetQueryable<Autopart>()
          .Include(a => a.AutopartInfos)
          .Include(a => a.AutopartAssets)
          .ToListAsync();

      foreach (var dto in syncData)
      {
        var existingAutopart = existingAutoparts.FirstOrDefault(x => x.Id == dto?.RefId);

        if (existingAutopart != null)
        {
          existingAutopart.BrandId = dto.BrandId;
          existingAutopart.Name = dto.Name;
          existingAutopart.CategoryId = dto.CategoryId;
          existingAutopart.DeleteAt = DateTime.MinValue;
          await _repo.Update(existingAutopart);

          await SyncAutopartInfos(existingAutopart.Id, dto.Infos);

          await SyncAutopartAssets(existingAutopart.Id, dto.Assets);
        }
        else
        {
          var newAutopart = _mapper.Map<Autopart>(dto);
          await _repo.Create(newAutopart);

          if (dto.Infos != null && dto.Infos.Any())
          {
            var newInfos = dto.Infos.Select(info => new AutopartInfo
            {
              Value = info.Value,
              TypeId = info.TypeId,
              AutopartId = newAutopart.Id
            }).ToList();

            await _repo.CreateRange(newInfos);
          }

          if (dto.Assets != null && dto.Assets.Any())
          {
            var newAssets = new List<AutopartAsset>();
            foreach (var assetDto in dto.Assets)
            {
              var assetPath = assetDto.Asset != null
                  ? _cloudinary.UploadFile(assetDto.Asset, $"SanAndres/Assets")
                  : null;

              newAssets.Add(new AutopartAsset
              {
                Asset = assetPath,
                Description = assetDto.Description,
                AutopartId = newAutopart.Id
              });
            }

            await _repo.CreateRange(newAssets);
          }
        }
      }

      var autopartsToDelete = existingAutoparts
          .Where(existing => !syncData.Any(dto => dto.RefId == existing.Id))
          .ToList();

      foreach (var autopart in autopartsToDelete)
      {
        autopart.DeleteAt = DateTime.UtcNow;
        await _repo.Update(autopart);
      }

      return await _autopartService.GetAutoparts();
    }

    private async Task SyncAutopartInfos(int autopartId, List<AutopartInfoSyncDto> infoDtos)
    {
      if (infoDtos == null) return;

      var existingInfos = await _repo.GetQueryable<AutopartInfo>()
          .Where(x => x.AutopartId == autopartId)
          .ToListAsync();

      foreach (var infoDto in infoDtos)
      {
        var existingInfo = existingInfos.FirstOrDefault(x => x.Id == infoDto.RefId);

        if (existingInfo != null)
        {
          existingInfo.Value = infoDto.Value;
          existingInfo.TypeId = infoDto.TypeId;
          await _repo.Update(existingInfo);
        }
        else
        {
          var newInfo = new AutopartInfo
          {
            Value = infoDto.Value,
            TypeId = infoDto.TypeId,
            AutopartId = autopartId
          };
          await _repo.Create(newInfo);
        }
      }
      
      var infosToDelete = existingInfos
              .Where(existing => !infoDtos.Any(dto => dto.RefId == existing.Id))
              .ToList();

      foreach (var info in infosToDelete)
      {
        info.DeleteAt = DateTime.UtcNow;
        await _repo.Update(info);
      }
    }

    private async Task SyncAutopartAssets(int autopartId, List<AutopartAssetSyncDto> assetDtos)
    {
      if (assetDtos == null) return;

      var existingAssets = await _repo.GetQueryable<AutopartAsset>()
          .Where(x => x.AutopartId == autopartId)
          .ToListAsync();

      foreach (var assetDto in assetDtos)
      {
        var existingAsset = existingAssets.FirstOrDefault(x => x.Id == assetDto.RefId);

        if (existingAsset != null)
        {
          existingAsset.Description = assetDto.Description;

          if (assetDto.Asset != null)
          {
            existingAsset.Asset = _cloudinary.UploadFile(assetDto.Asset, $"SanAndres/Assets");
          }

          await _repo.Update(existingAsset);
        }
        else
        {
          var assetPath = assetDto.Asset != null
              ? _cloudinary.UploadFile(assetDto.Asset, $"SanAndres/Assets")
              : null;

          var newAsset = new AutopartAsset
          {
            Asset = assetPath,
            Description = assetDto.Description,
            AutopartId = autopartId
          };

          await _repo.Create(newAsset);
        }
      }

      var assetsToDelete = existingAssets
        .Where(existing => !assetDtos.Any(dto => dto.RefId == existing.Id))
        .ToList();

      foreach (var asset in assetsToDelete)
      {
        asset.DeleteAt = DateTime.UtcNow;
        await _repo.Update(asset);
      }
    }
  }
}