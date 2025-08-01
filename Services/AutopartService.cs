using AutoMapper;
using SanAndres_Api.Repositories.Interfaces;

namespace SanAndres_Api.Services
{
  public class AutopartService
  {
    private readonly IMapper _mapper;
    private readonly ITRepository _repo;
    public AutopartService(ITRepository repo, IMapper mapper)
    {
      _repo = repo;
      _mapper = mapper;
    }


    // public async Task
  }
}