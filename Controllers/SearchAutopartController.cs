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
    [Route("api/v1/search-autopart")]
    [ApiController]
    public class SearchAutopartController : ControllerBase
    {
        private readonly ILogger<SearchAutopartController> _logger;
        private readonly ISearchAutopartService _service;
        public SearchAutopartController(ILogger<SearchAutopartController> logger, ISearchAutopartService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> SearchAutopart([FromQuery] AutopartFilterDto filter)
        {
            try
            {
                var list = await _service.SearchAutopartsByFilter(filter);
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
