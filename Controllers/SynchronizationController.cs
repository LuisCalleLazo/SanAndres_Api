using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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
  [Authorize]
  [Route("api/v1/syncronization")]
  [ApiController]
  public class SyncronizationController : ControllerBase
  {
    private readonly ILogger<SyncronizationController> _logger;
    private readonly ISyncService _service;
    public SyncronizationController(ILogger<SyncronizationController> logger, ISyncService service)
    {
      _logger = logger;
      _service = service;
    }

    [HttpPost("autoparts-of-seller")]
    public async Task<IActionResult> SyncronizationAutopartOfSeller([FromBody] List<AutopartOfSellerSyncDto> syncData)
    {
      try
      {
        var userId = Int32.Parse(User.FindFirst("id")?.Value);
        var seller = User.FindFirst("seller")?.Value;

        if (seller != "True")
          return Unauthorized("Usuario no autorizado");

        var result = await _service.SyncAutopartsOfSeller(userId, syncData);

        return Ok(result);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpPost("customers")]
    public async Task<IActionResult> SyncronizationCustomers([FromBody] List<CustomerOfSellerSyncDto> syncData)
    {
      try
      {
        var userId = Int32.Parse(User.FindFirst("id")?.Value);
        var seller = User.FindFirst("seller")?.Value;

        if (seller != "True")
          return Unauthorized("Usuario no autorizado");

        var result = await _service.SyncCustomerOfSeller(userId, syncData);

        return Ok(result);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    // [HttpPost("sales")]
    // public async Task<IActionResult> SyncronizationSales([FromBody] List<AutopartOfSellerDto> syncData)
    // {
    //   try
    //   {
    //     var userId = Int32.Parse(User.FindFirst("id")?.Value);
    //     var seller = User.FindFirst("seller")?.Value;

    //     if (seller != "True")
    //       return Unauthorized("Usuario no autorizado");

    //     var result = await _service.SyncAutopartsOfSeller(userId, syncData);

    //     return Ok(result);
    //   }
    //   catch (Exception err)
    //   {
    //     _logger.LogError(err.Message);
    //     Console.WriteLine(err.StackTrace);
    //     return BadRequest(err.Message);
    //   }
    // }


    // [HttpPost("buys")]
    // public async Task<IActionResult> SyncronizationBuys([FromBody] List<AutopartOfSellerDto> syncData)
    // {
    //   try
    //   {
    //     var userId = Int32.Parse(User.FindFirst("id")?.Value);
    //     var seller = User.FindFirst("seller")?.Value;

    //     if (seller != "True")
    //       return Unauthorized("Usuario no autorizado");

    //     var result = await _service.SyncAutopartsOfSeller(userId, syncData);

    //     return Ok(result);
    //   }
    //   catch (Exception err)
    //   {
    //     _logger.LogError(err.Message);
    //     Console.WriteLine(err.StackTrace);
    //     return BadRequest(err.Message);
    //   }
    // }

    // [HttpPost("autoparts")]
    // public async Task<IActionResult> SyncronizationAutoparts([FromBody] List<AutopartOfSellerDto> syncData)
    // {
    //   try
    //   {
    //     var userId = Int32.Parse(User.FindFirst("id")?.Value);
    //     var seller = User.FindFirst("seller")?.Value;

    //     if (seller != "True")
    //       return Unauthorized("Usuario no autorizado");

    //     var result = await _service.SyncAutopartsOfSeller(userId, syncData);

    //     return Ok(result);
    //   }
    //   catch (Exception err)
    //   {
    //     _logger.LogError(err.Message);
    //     Console.WriteLine(err.StackTrace);
    //     return BadRequest(err.Message);
    //   }
    // }

  }
}