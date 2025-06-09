using System.IdentityModel.Tokens.Jwt;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Controllers
{
  [Route("api/v1/autopart")]
  [ApiController]
  public class AutopartController : ControllerBase
  {
    private readonly ILogger<AutopartController> _logger;
    private readonly ICloudinaryService _cloudinary;
    private readonly ITRepository _repo;
    private readonly IMapper _mapper;
    public AutopartController(ILogger<AutopartController> logger, ITRepository repo, IMapper mapper, ICloudinaryService cloudinary)
    {
      _logger = logger;
      _repo = repo;
      _mapper = mapper;
      _cloudinary = cloudinary;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AutopartToCreateDto request)
    {
      try
      {

        var create = _mapper.Map<Autopart>(request);
        await _repo.Create(create);
        return Ok(create);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpGet("list")]
    public async Task<IActionResult> GetAutoparts()
    {
      try
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

        return Ok(list);


      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpGet("brands")]
    public async Task<IActionResult> GetBrands()
    {
      try
      {
        var list = _mapper.Map<List<AutopartBrandToListDto>>(await _repo.GetAll<AutopartBrand>());

        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }



    [HttpGet("categories")]
    public async Task<IActionResult> GetCategories()
    {
      try
      {
        var list = _mapper.Map<List<AutopartCategoryToListDto>>(await _repo.GetAll<Category>());

        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpPost("info")]
    public async Task<IActionResult> CreateInfo([FromBody] AutopartInfoToCreate create)
    {
      try
      {
        var newInfo = _mapper.Map<AutopartInfo>(create);
        await _repo.Create(newInfo);
        return Ok(newInfo);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }
    [HttpDelete("info/{id}")]
    public async Task<IActionResult> DeleteInfo(int id)
    {
      try
      {
        var info = await _repo.GetById<AutopartInfo>(id);
        await _repo.Remove(info);
        return Ok("Eliminado correctamente!");
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPost("asset")]
    public async Task<IActionResult> CreateAsset([FromForm] AutopartAssetToCreate create)
    {
      try
      {
        string path_asset = _cloudinary.UploadFile(create.Asset, $"SanAndres/Assets");
        var newAsset = _mapper.Map<AutopartAsset>(create);
        newAsset.Asset = path_asset;
        await _repo.Create(newAsset);
        return Ok(newAsset);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("asset/{id}")]
    public async Task<IActionResult> DeleteAsset(int id)
    {
      try
      {
        var asset = await _repo.GetById<AutopartAsset>(id);
        await _repo.Remove(asset);
        return Ok("Eliminado correctamente!");
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPost("of-seller")]
    public async Task<IActionResult> CreateOfSeller([FromBody] AutopartOfSellerDto request)
    {
      try
      {
        var autopart = new AutopartOfSeller
        {
          AutopartId = request.AutopartId,
          SellerId = request.SellerId,
          AmountUnit = request.AmountUnit,
          AmountUnitPublic = request.AmountUnitPublic,
          UnitPrice = request.UnitPrice,
          UnitPricePublic = request.UnitPricePublic,
          WholessalePrice = request.WholessalePrice,
          WholessalePricePublic = request.WholessalePricePublic
        };

        await _repo.Create(autopart);

        return Ok(autopart);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpGet("of-seller/{sellerId}")]
    public async Task<IActionResult> GetAutopartss(int sellerId)
    {
      try
      {
        var list = await _repo.GetQueryable<AutopartOfSeller>()
          .Include(x => x.Autopart)
        .ToListAsync();
        return Ok(_mapper.Map<List<AutopartOfSellerDto>>(list));
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPatch("of-seller/{id}")]
    public async Task<IActionResult> PatchAutopartOfSeller(int id, [FromBody] AutopartOfSellerToUpdateDto update)
    {
      try
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
        return Ok(autopart);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpDelete("of-seller/{id}")]
    public async Task<IActionResult> DeleteAutopartOfSeller(int id)
    {
      try
      {
        var autopart = await _repo.GetById<AutopartOfSeller>(id);
        await _repo.Remove(autopart);
        return Ok("Se elimino correctamente");
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

  }

}