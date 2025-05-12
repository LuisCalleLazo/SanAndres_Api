using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SanAndres_Api.Dtos;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Controllers
{
  [Route("api/v1/auth")]
  [ApiController]
  public class AuthController : ControllerBase
  {
    private readonly IAuthService _service;
    private readonly ILogger<AuthController> _logger;
    private readonly IUserService _userServ;
    public AuthController(IAuthService service, ILogger<AuthController> logger, IUserService userServ)
    {
      _service = service;
      _logger = logger;
      _userServ = userServ;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] AuthRequestDto request)
    {
      try
      {
        var auth = await _service.Login(request);
        
        if(auth == null)
          return BadRequest("Credenciales incorrectas!!");
        
        return Ok(auth);
      }catch(Exception err)
      {
        _logger.LogError(err.Message);
        _logger.LogError(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    // [Authorize]
    [HttpPost("register-user")]
    public async Task<IActionResult> RegisterUser([FromBody] AuthRegisterDto create)
    {
      try
      {

        if(await _userServ.GetUserByName(create.Name) != null)
          return BadRequest("El nombre ya esta registrado");

          
        if(await _userServ.GetUserByEmail(create.Email) != null)
          return BadRequest("El email ya esta registrado");

        var response =  await _service.RegisterUser(create);
        
        return Ok(response);
      }
      catch(Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

    [HttpPost("refresh-token")]
    public async Task<IActionResult> RefreshToken([FromBody] AuthRefreshTokenRequestDto refresh)
    {
      try
      {
        var tokenHandler = new JwtSecurityTokenHandler();
        var tokenExpired = tokenHandler.ReadJwtToken(refresh.TokenExpired);

        if(tokenExpired.ValidTo > DateTime.UtcNow)
          return BadRequest("Token no ha expirado");

        int IdUser = Int32.Parse(tokenExpired.Claims.First(x => x.Type == "id").Value);

        if(!await _service.ValidateRefreshToken(refresh, IdUser))
          return BadRequest("El token y refresh token son invalidos");

        var authResponse = await _service.RefreshToken(IdUser);
        
        return Ok(authResponse);
        
      }catch(Exception err)
      {
        _logger.LogError(err.Message);
        Console.WriteLine(err.StackTrace);
        return BadRequest(err.Message);
      }
    }

  }
}