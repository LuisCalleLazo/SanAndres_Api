using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class SearchAutopartService : ISearchAutopartService
  {
    private readonly ITRepository _repo;
    public SearchAutopartService(ITRepository repo)
    {
      _repo = repo;
    }

    public async Task<List<AutopartToListDto>> SearchAutopartsByFilter(AutopartFilterDto filter)
    {
      IQueryable<Autopart> baseQuery = _repo.GetQueryable<Autopart>()
                  .Include(x => x.AutopartAssets)
                  .Include(x => x.AutopartInfos)
                      .ThenInclude(i => i.AutopartTypeInfo)
                  .Include(x => x.AutopartBrand)
                  .Include(x => x.Category)
                  .Include(x => x.Sales)
                  .Include(x => x.AutopartOfSellers);

      // Aplicar filtros
      if (!string.IsNullOrEmpty(filter.ProductName))
        baseQuery = baseQuery.Where(a => a.Name.Contains(filter.ProductName));

      if (filter.CategoryId.HasValue)
        baseQuery = baseQuery.Where(a => a.CategoryId == filter.CategoryId);

      if (filter.BrandId.HasValue)
        baseQuery = baseQuery.Where(a => a.BrandId == filter.BrandId);

      if (filter.MinPrice.HasValue || filter.MaxPrice.HasValue)
      {
        baseQuery = baseQuery.Where(a => a.AutopartOfSellers.Any(s =>
            (!filter.MinPrice.HasValue || s.UnitPrice >= filter.MinPrice) &&
            (!filter.MaxPrice.HasValue || s.UnitPrice <= filter.MaxPrice)
        ));
      }

      // Verificar si hay filtros aplicados
      bool hasFilters = !string.IsNullOrEmpty(filter.ProductName) ||
                      filter.CategoryId.HasValue ||
                      filter.BrandId.HasValue ||
                      filter.MinPrice.HasValue ||
                      filter.MaxPrice.HasValue;

      IQueryable<AutopartToListDto> resultQuery;

      if (hasFilters)
      {
        resultQuery = baseQuery.Select(x => new
        {
          Autopart = x,
          CheapestSeller = x.AutopartOfSellers
            .OrderBy(s => s.UnitPrice)
            .FirstOrDefault()
        })
        .Select(x => new AutopartDetailDto
        {
          Id = x.Autopart.Id,
          Name = x.Autopart.Name,
          BrandId = x.Autopart.AutopartBrand.Id,
          BrandName = x.Autopart.AutopartBrand.Name,
          CategoryId = x.Autopart.Category.Id,
          CategoryName = x.Autopart.Category.Name,
          UnitPrice = x.CheapestSeller != null ? x.CheapestSeller.UnitPrice : 0,
          SellerId = x.CheapestSeller != null ? x.CheapestSeller.SellerId : 0,
          Infos = x.Autopart.AutopartInfos.Select(info => new AutopartInfoDto
          {
            Id = info.Id,
            Value = info.Value,
            TypeId = info.TypeId,
            TypeName = info.AutopartTypeInfo.Name,
            Type = (AutopartTypeInfoEnum)info.TypeId
          }).ToList(),
          Assets = x.Autopart.AutopartAssets.Select(asset => new AutopartAssetDto
          {
            Id = asset.Id,
            Asset = asset.Asset,
            Description = asset.Description
          }).ToList()
        });
      }
      else
      {
        resultQuery = baseQuery
            .Select(x => new
            {
              Autopart = x,
              CheapestSeller = x.AutopartOfSellers
                  .OrderBy(s => s.UnitPrice)
                  .FirstOrDefault(),
              SalesScore = x.Sales.Sum(s => s.Amount) * (1 + (x.AutopartOfSellers.Average(s => s.UnitPrice) / 1000))
            })
            .OrderByDescending(x => x.SalesScore)
            .Take(10)
            .Select(x => new AutopartDetailDto
            {
              Id = x.Autopart.Id,
              Name = x.Autopart.Name,
              BrandId = x.Autopart.AutopartBrand.Id,
              BrandName = x.Autopart.AutopartBrand.Name,
              CategoryId = x.Autopart.Category.Id,
              CategoryName = x.Autopart.Category.Name,
              UnitPrice = x.CheapestSeller != null ? x.CheapestSeller.UnitPrice : 0,
              SellerId = x.CheapestSeller != null ? x.CheapestSeller.SellerId : 0,
              Infos = x.Autopart.AutopartInfos.Select(info => new AutopartInfoDto
              {
                Id = info.Id,
                Value = info.Value,
                TypeId = info.TypeId,
                TypeName = info.AutopartTypeInfo.Name,
                Type = (AutopartTypeInfoEnum)info.TypeId
              }).ToList(),
              Assets = x.Autopart.AutopartAssets.Select(asset => new AutopartAssetDto
              {
                Id = asset.Id,
                Asset = asset.Asset,
                Description = asset.Description
              }).ToList()
            });
      }

      return await resultQuery.ToListAsync();
    }
  }
}