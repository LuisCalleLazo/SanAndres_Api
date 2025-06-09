using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Controllers
{
  [Route("api/v1/syncronization")]
  [ApiController]
  public class SyncronizationController : ControllerBase
  {
    private readonly ILogger<SyncronizationController> _logger;
    private readonly ITRepository _repo;
    private readonly IMapper _mapper;
    public SyncronizationController(ILogger<SyncronizationController> logger, ITRepository repo, IMapper mapper)
    {
      _logger = logger;
      _repo = repo;
      _mapper = mapper;
    }

    [HttpPost("autoparts")]
    public async Task<IActionResult> SyncronizationAutopart([FromBody] List<AutopartOfSellerDto> syncData)
    {
      try
      {
        var userId = User.FindFirstValue("id");

        if (userId == null)
          return BadRequest("No identificado");

        int sellerId = Int32.Parse(userId);

        // Obtener autopartes existentes del vendedor
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

        return Ok(autopartsFinally);
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