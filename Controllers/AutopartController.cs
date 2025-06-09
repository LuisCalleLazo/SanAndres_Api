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
    private readonly IUserService _userServ;
    private readonly ITRepository _repo;
    private readonly IMapper _mapper;
    public AutopartController(ILogger<AutopartController> logger, IUserService userServ, ITRepository repo, IMapper mapper)
    {
      _logger = logger;
      _userServ = userServ;
      _repo = repo;
      _mapper = mapper;
    }

    [HttpPost("of-seller")]
    public async Task<IActionResult> Create([FromBody] AutopartOfSellerDto request)
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


    [HttpGet]
    public async Task<IActionResult> GetAutopartss()
    {
      try
      {
        var list = await _repo.GetAll<AutopartOfSeller>();
        return Ok(_mapper.Map<List<AutopartOfSellerDto>>(list));

      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
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
          .Include(x => x.AutopartBrand)
          .Include(x => x.Category)
          .ToListAsync();
        return Ok(list);
        
      }catch(Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

  }
}