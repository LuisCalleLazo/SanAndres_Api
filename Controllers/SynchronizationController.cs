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
    private readonly IUserService _userServ;
    private readonly ITRepository _repo;
    private readonly IMapper _mapper;
    public SyncronizationController(ILogger<SyncronizationController> logger, IUserService userServ, ITRepository repo, IMapper mapper)
    {
      _logger = logger;
      _userServ = userServ;
      _repo = repo;
      _mapper = mapper;
    }



    [HttpPost("brand")]
    public async Task<IActionResult> SyncronizationBrand()
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

    [HttpPost("autopart")]
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


    [HttpPost("sale")]
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
    


  }
}