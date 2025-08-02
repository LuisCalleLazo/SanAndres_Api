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
    private readonly IAutopartService _service;
    private readonly IAutopartDataService _dataServ;
    public AutopartController(ILogger<AutopartController> logger, IAutopartService service, IAutopartDataService dataServ)
    {
      _logger = logger;
      _service = service;
      _dataServ = dataServ;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AutopartToCreateDto request)
    {
      try
      {
        var created = await _service.CreateAutopart(request);
        return Ok(created);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpGet]
    public async Task<IActionResult> GetAutoparts()
    {
      try
      {
        var list = await _service.GetAutoparts();
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
        var list = await _dataServ.GetBrands();
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
        var list = await _dataServ.GetCategories();
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
        var newInfo = await _dataServ.CreateInfo(create);
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
        await _dataServ.DeleteInfo(id);
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
        var newAsset = await _dataServ.CreateAsset(create);
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
        await _dataServ.DeleteAsset(id);
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
    public async Task<IActionResult> CreateOfSeller([FromBody] AutopartOfSellerToCreateDto request)
    {
      try
      {
        var userId = Int32.Parse(User.FindFirst("id")?.Value);
        var seller = User.FindFirst("seller")?.Value;

        if (seller != "True")
          return Unauthorized("Usuario no autorizado");
        var autopart = await _service.CreateAutopartOfSeller(request, userId);

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
        var list = await _service.GetAutopartOfSeller();
        return Ok(list);
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
        var autopart = await _service.UpdateAutopart(update, id);
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
        await _service.DeleteAutopartOfSeller(id);
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