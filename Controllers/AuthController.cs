using Microsoft.AspNetCore.Mvc;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Controllers
{
  [Route("api/v1/auth")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly IAuthService _service;
    private readonly ILogger<AuthController> _logger;
    public AuthController(IAuthService service, ILogger<AuthController> logger)
    {
      _service = service;
      _logger = logger;
    }

    [HttpGet("login")]
    public IActionResult Login()
    {
      try
      {
        return Ok("Hola que hace");
      }
      catch(Exception err)
      {
        return BadRequest(err.Message);
      }
    }
  }
}