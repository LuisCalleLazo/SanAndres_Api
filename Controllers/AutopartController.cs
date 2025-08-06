using System.IdentityModel.Tokens.Jwt;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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


    [HttpGet("brand")]
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

    [HttpPost("brand")]
    public async Task<IActionResult> CreateBrand([FromForm] AutopartBrandToCreate create)
    {
      try
      {
        var list = await _dataServ.CreateAutopartBrand(create);
        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPatch("brand/{id}")]
    public async Task<IActionResult> UpdateBrand(int id, [FromForm] AutopartBrandToUpdate update)
    {
      try
      {
        var list = await _dataServ.UpdateAutopartBrand(update, id);
        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("brand/{id}")]
    public async Task<IActionResult> DeleteBrand(int id)
    {
      try
      {
        var list = await _dataServ.DeleteAutopartBrand(id);
        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpGet("category")]
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

    [HttpPost("category")]
    public async Task<IActionResult> CreateCategories([FromBody] AutopartCategoryToCreate create)
    {
      try
      {
        var list = await _dataServ.CreateCategory(create);
        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpPatch("category/{id}")]
    public async Task<IActionResult> UpdateCategories(int id, [FromBody] AutopartCategoryToCreate update)
    {
      try
      {
        var list = await _dataServ.UpdateCategory(update, id);
        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpDelete("category/{id}")]
    public async Task<IActionResult> DeleteCategory(int id)
    {
      try
      {
        var list = await _dataServ.DeleteCategory(id);
        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpGet("type-info")]
    public async Task<IActionResult> ListTypesInfo()
    {
      try
      {
        var newInfo = await _dataServ.GetAutopartInfoTypes();
        return Ok(newInfo);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPost("type-info")]
    public async Task<IActionResult> CreateTypeInfo(AutopartInfoTypeToCreateDto create)
    {
      try
      {
        var newInfo = await _dataServ.CreateAutopartInfoType(create);
        return Ok(newInfo);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPatch("type-info/{id}")]
    public async Task<IActionResult> PatchTypeInfo(int id, [FromBody] AutopartInfoTypeToUpdateDto update)
    {
      try
      {
        var newInfo = await _dataServ.UpdateAutopartInfoType(update, id);
        return Ok(newInfo);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }
    
    [HttpDelete("type-info/{id}")]
    public async Task<IActionResult> DeleteTypeInfo(int id)
    {
      try
      {
        var newInfo = await _dataServ.DeleteAutopartTypeInfo(id);
        return Ok(newInfo);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
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
  }

}