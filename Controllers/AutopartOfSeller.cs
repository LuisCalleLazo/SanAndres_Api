using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanAndres_Api.Dtos;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Controllers
{
  [Authorize]
  [Route("api/v1/autopart-of-seller")]
  [ApiController]
  public class AutopartOfSellerController : ControllerBase
  {

    private readonly ILogger<AutopartOfSellerController> _logger;
    private readonly IAutopartOfSellerService _service;

    public AutopartOfSellerController(ILogger<AutopartOfSellerController> logger, IAutopartOfSellerService service)
    {
      _logger = logger;
      _service = service;
    }


    [HttpPost]
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

    [HttpGet]
    public async Task<IActionResult> GetAutopartss()
    {
      try
      {
        var userId = Int32.Parse(User.FindFirst("id")?.Value);
        var seller = User.FindFirst("seller")?.Value;

        if (seller != "True")
          return Unauthorized("Usuario no autorizado");

        var list = await _service.GetAutopartOfSeller(userId);
        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchAutopartOfSeller(int id, [FromBody] AutopartOfSellerToUpdateDto update)
    {
      try
      {
        var autopart = await _service.UpdateAutopartOfSeller(update, id);
        return Ok(autopart);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }


    [HttpDelete("{id}")]
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