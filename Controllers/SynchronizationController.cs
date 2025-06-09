using System.IdentityModel.Tokens.Jwt;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
    public async Task<IActionResult> SyncronizationAutopart()
    {
      try
      {

        return Ok("asdasd");
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpPost("sales")]
    public async Task<IActionResult> SyncronizationSale()
    {
      try
      {

        return Ok("asdasd");
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPost("customers")]
    public async Task<IActionResult> SyncronizationCustomers()
    {
      try
      {

        return Ok("asdasd");
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