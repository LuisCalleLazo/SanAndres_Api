using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Controllers
{
    [Route("api/v1/sales")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ILogger<SaleController> _logger;
        private readonly ISaleService _service;

        public SaleController(ILogger<SaleController> logger, ISaleService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("list/{sellerId}")]
        public async Task<IActionResult> GetSales(int sellerId)
        {
            try
            {
                var result = await _service.GetList(sellerId);
                return Ok(result);
            }
            catch (Exception err)
            {
                _logger.LogError(err.Message);
                Console.WriteLine(err.StackTrace);
                return BadRequest(err.Message);
            }
        }
        [HttpGet("list/item/{saleDetailId}")]
        public async Task<IActionResult> GetSalesItems(int saleDetailId)
        {
            try
            {
                var result = await _service.GetSaleItems(saleDetailId);
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
                await _service.CreateSale(createDto);
                return NoContent();
            }
            catch (Exception err)
            {
                _logger.LogError(err.Message);
                Console.WriteLine(err.StackTrace);
                return BadRequest(err.Message);
            }
        }

        [HttpPost("item")]
        public async Task<IActionResult> CreateSaleItem([FromBody] SaleToAddDto createDto)
        {
            try
            {
                var create = await _service.CreateSaleItem(createDto);
                return Ok(create);
            }
            catch (Exception err)
            {
                _logger.LogError(err.Message);
                Console.WriteLine(err.StackTrace);
                return BadRequest(err.Message);
            }
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateSale(int id, [FromBody] SaleDetailToUpdateDto updateDto)
        {
            try
            {
                await _service.UpdateSale(updateDto, id);
                return NoContent();
            }
            catch (Exception err)
            {
                _logger.LogError(err.Message);
                Console.WriteLine(err.StackTrace);
                return BadRequest(err.Message);
            }
        }

        [HttpPatch("item/{id}")]
        public async Task<IActionResult> UpdateSaleItem(int id, [FromBody] SaleToUpdateDto updateDto)
        {
            try
            {
                await _service.UpdateSaleItem(updateDto, id);
                return NoContent();
            }
            catch (Exception err)
            {
                _logger.LogError(err.Message);
                Console.WriteLine(err.StackTrace);
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSale(int id)
        {
            try
            {
                await _service.DeleteSale(id);
                return NoContent();
            }
            catch (Exception err)
            {
                _logger.LogError(err.Message);
                Console.WriteLine(err.StackTrace);
                return BadRequest(err.Message);
            }
        }
        
        [HttpDelete("item/{id}")]
        public async Task<IActionResult> DeleteSaleItem(int id)
        {
            try
            {
                await _service.DeleteSaleItem(id);
                return NoContent();
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