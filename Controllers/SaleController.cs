using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;

namespace SanAndres_Api.Controllers
{
    [Route("api/v1/sales")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ILogger<SaleController> _logger;
        private readonly ITRepository _repo;
        private readonly IMapper _mapper;

        public SaleController(ILogger<SaleController> logger, ITRepository repo, IMapper mapper)
        {
            _logger = logger;
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetSales()
        {
            try
            {

                return Ok("list");
            }
            catch (Exception err)
            {
                _logger.LogError(err.Message);
                Console.WriteLine(err.StackTrace);
                return BadRequest(err.Message);
            }
        }

        [HttpPost]

        public async Task<IActionResult> CreateSale([FromBody] SaleDetailToCreateDto createDto)
        {
            try
            {
                var saleDetail = _mapper.Map<SaleDetail>(createDto);
                
                if (createDto.SaleDate == default)
                {
                    saleDetail.SaleDate = DateTime.Now;
                }
                
                // Mapear cada SaleToCreateDto a Sale y asignar la relación
                saleDetail.Sales = _mapper.Map<List<Sale>>(createDto.Items);
                
                // Asignar el SaleDetailId a cada Sale (esto se puede hacer automáticamente con EF Core)
                foreach (var sale in saleDetail.Sales)
                {
                    sale.SaleDetail = saleDetail;
                }

                // Guardar en la base de datos
                await _repo.Create(saleDetail);
                
                return Ok("Venta guardada!");
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