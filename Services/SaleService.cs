using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class SaleService : ISaleService
  {
    private readonly ITRepository _repo;
    private readonly IMapper _mapper;
    public SaleService(ITRepository repo, IMapper mapper)
    {
      _repo = repo;
      _mapper = mapper;
    }

    public async Task<List<SaleDetailDto>> GetList(int sellerId)
    {
      var saleDetails = await _repo.GetQueryable<SaleDetail>()
          .Include(sd => sd.Customer)
          .Include(sd => sd.Seller)
          .Where(x => x.Seller.Id == sellerId && x.DeleteAt == DateTime.MinValue)
          .ToListAsync();


      var tasks = saleDetails.Select(async sd =>
      {
        var saleItems = await GetSaleItems(sd.Id);
        var totalPrice = saleItems.Sum(x => x.Price * x.Amount);

        return new SaleDetailDto
        {
          Id = sd.Id,
          CustomerId = sd.CustomerId,
          CustomerNotSubscribed = sd.CustomerNotSubscribed,
          SellerId = sd.SellerId,
          SaleDate = sd.SaleDate,
          State = sd.State,
          TotalPrice = totalPrice
        };
      }).ToList();

      var result = await Task.WhenAll(tasks);

      return result.ToList();
    }

    public async Task<List<SaleDto>> GetSaleItems(int saleDetailId)
    {
      var sales = await _repo.GetQueryable<Sale>()
        .Include(x => x.Autopart)
          .ThenInclude(a => a.AutopartAssets)
        .Where(x => x.DeleteAt == DateTime.MinValue && x.SaleDetailId == saleDetailId)
        .ToListAsync();


      return sales?.Select(s => new SaleDto
      {
        Id = s.Id,
        AutopartName = s.Autopart?.Name,
        AutopartAsset = s.Autopart?.AutopartAssets?.FirstOrDefault()?.Asset,
        Amount = s.Amount,
        Price = s.Price,
      }).ToList();
    }

    public async Task CreateSale(SaleDetailToCreateDto create)
    {

      var saleDetail = _mapper.Map<SaleDetail>(create);

      if (create.SaleDate == default)
        saleDetail.SaleDate = DateTime.Now;


      saleDetail.Sales = _mapper.Map<List<Sale>>(create.Items);

      foreach (var sale in saleDetail.Sales)
      {
        sale.SaleDetail = saleDetail;
      }

      await _repo.Create(saleDetail);
    }

    public async Task<SaleDto> CreateSaleItem(SaleToAddDto create)
    {
      var sale = _mapper.Map<Sale>(create);

      await _repo.Create(sale);

      return _mapper.Map<SaleDto>(sale);
    }

    public async Task UpdateSale(SaleDetailToUpdateDto update, int id)
    {
      var saleDetail = await _repo.GetById<SaleDetail>(id);

      if (update.SaleDate != null)
        saleDetail.SaleDate = (DateTime)update.SaleDate;

      if (update.State != null)
        saleDetail.State = (SaleState)update.State;

      if (update.SellerId != null)
        saleDetail.SellerId = (int)update.SellerId;

      if (update.CustomerId != null)
        saleDetail.CustomerId = (int)update.CustomerId;

      if (update.CustomerNotSubscribed != null)
        saleDetail.CustomerNotSubscribed = update.CustomerNotSubscribed;

      await _repo.Update(saleDetail);
    }

    public async Task UpdateSaleItem(SaleToUpdateDto update, int id)
    {
      var sale = await _repo.GetById<Sale>(id);

      if (update.AutopartId != null)
        sale.AutopartId = (int)update.AutopartId;

      if (update.Amount != null)
        sale.Amount = (int)update.Amount;

      if (update.Price != null)
        sale.Price = (decimal)update.Price;

      await _repo.Update(sale);
    }

    public async Task DeleteSale(int id)
    {
      var saleDetail = await _repo.GetById<SaleDetail>(id);

      saleDetail.DeleteAt = DateTime.UtcNow;
      await _repo.Update(saleDetail);

      var sales = await _repo.GetQueryable<Sale>().Where(x => x.SaleDetailId == saleDetail.Id).ToListAsync();

      foreach (var item in sales)
      {
        item.DeleteAt = DateTime.UtcNow;
        await _repo.Update(item);
      }
    }

    public async Task DeleteSaleItem(int id)
    {
      var sale = await _repo.GetById<Sale>(id);
      sale.DeleteAt = DateTime.UtcNow;
      await _repo.Update(sale);
    }
  }
}