using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Dtos;
using SanAndres_Api.Models;
using SanAndres_Api.Repositories.Interfaces;
using SanAndres_Api.Services.Interfaces;

namespace SanAndres_Api.Services
{
  public class CustomerOfSellerService : ICustomerOfSellerService
  {
    private readonly ITRepository _trepo;
    private readonly IMapper _mapper;
    public CustomerOfSellerService(ITRepository repo, IMapper mapper)
    {
      _trepo = repo;
      _mapper = mapper;
    }

    public async Task<List<CustomerToDetailDto>> GetListBySeller(int sellerId)
    {
      var customers = await _trepo.GetQueryable<CustomerOfSeller>()
        .Where(x => x.SellerId == sellerId && x.DeleteAt == DateTime.MinValue)
        .ToListAsync();

      return _mapper.Map<List<CustomerToDetailDto>>(customers);
    }

    public async Task<CustomerToDetailDto> Create(CustomerToCreateDto create, int sellerId)
    {
      var customerNew = _mapper.Map<CustomerOfSeller>(create);
      customerNew.SellerId = sellerId;
      await _trepo.Create(customerNew);

      return _mapper.Map<CustomerToDetailDto>(customerNew);
    }

    public async Task<CustomerToDetailDto> Update(CustomerToUpdateDto update, int customerId, int sellerId)
    {
      var customerNew = _mapper.Map<CustomerOfSeller>(update);
      customerNew.Id = customerId;
      customerNew.SellerId = sellerId;

      await _trepo.Update(customerNew);
      return _mapper.Map<CustomerToDetailDto>(customerNew);
    }

    public async Task<CustomerToDetailDto> Delete(int customerId)
    {
      var customer = await _trepo.GetById<CustomerOfSeller>(customerId);
      customer.DeleteAt = DateTime.UtcNow;
      await _trepo.Update(customer);
      return _mapper.Map<CustomerToDetailDto>(customer);
    }


  }
}