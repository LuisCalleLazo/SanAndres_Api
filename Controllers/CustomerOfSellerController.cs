using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanAndres_Api.Dtos;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Controllers
{
  [Authorize]
  [Route("api/v1/customer-of-seller")]
  [ApiController]
  public class CustomerOfSellerController : ControllerBase
  {
    private readonly ILogger<CustomerOfSellerController> _logger;
    private readonly ICustomerOfSellerService _service;
    public CustomerOfSellerController(ILogger<CustomerOfSellerController> logger, ICustomerOfSellerService service)
    {
      _service = service;
      _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
      try
      {
        var userId = Int32.Parse(User.FindFirst("id")?.Value);
        var seller = User.FindFirst("seller")?.Value;

        if (seller != "True")
          return Unauthorized("Usuario no autorizado");

        var list = await _service.GetListBySeller(userId);
        return Ok(list);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }
    [HttpPost]
    public async Task<IActionResult> Create(CustomerToCreateDto create)
    {
      try
      {
        var userId = Int32.Parse(User.FindFirst("id")?.Value);
        var seller = User.FindFirst("seller")?.Value;

        if (seller != "True")
          return Unauthorized("Usuario no autorizado");

        var created = await _service.Create(create, userId);
        return Ok(created);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CustomerToUpdateDto update)
    {
      try
      {
        var userId = Int32.Parse(User.FindFirst("id")?.Value);
        var seller = User.FindFirst("seller")?.Value;

        if (seller != "True")
          return Unauthorized("Usuario no autorizado");

        var updated = await _service.Update(update, id, userId);
        return Ok(updated);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      try
      {
        var seller = User.FindFirst("seller")?.Value;

        if (seller != "True")
          return Unauthorized("Usuario no autorizado");

        var deleted = await _service.Delete(id);
        return Ok(deleted);
      }
      catch (Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

  }
}