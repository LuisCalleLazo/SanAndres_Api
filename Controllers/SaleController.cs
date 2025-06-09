using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("list/{sellerId}")]
        public async Task<IActionResult> GetSales(int sellerId)
        {
            try
            {

                // Obtener todas las ventas con sus relaciones
                var saleDetails = await _repo.GetQueryable<SaleDetail>()
                    .Include(sd => sd.Sales)
                        .ThenInclude(s => s.Autopart)
                            .ThenInclude(a => a.AutopartAssets)
                    .Include(sd => sd.Customer)
                    .Include(sd => sd.Seller)
                    .Where(x => x.Seller.Id == sellerId)
                    .ToListAsync();

                // Mapear a DTO
                var result = saleDetails.Select(sd => new SaleDetailToListDto
                {
                    Id = sd.Id,
                    CustomerId = sd.CustomerId,
                    CustomerNotSubscribed = sd.CustomerNotSubscribed,
                    SellerId = sd.SellerId,
                    SaleDate = sd.SaleDate,
                    State = sd.State,
                    Items = sd.Sales?.Select(s => new SaleToListDto
                    {
                        Id = s.Id,
                        AutopartName = s.Autopart?.Name,
                        AutopartAsset = s.Autopart?.AutopartAssets?.FirstOrDefault()?.Asset, // Tomamos el primer asset
                        SaleDetailId = s.SaleDetailId,
                        Amount = s.Amount,
                        UnitPrice = s.UnitPrice,
                        WholessalePrice = s.WholessalePrice
                    }).ToList()
                }).ToList();

                return Ok(result);
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