using Microsoft.EntityFrameworkCore;
using SanAndres_Api.Database;
using SanAndres_Api.Repositories.Interfaces;

namespace SanAndres_Api.Repositories
{
  public class TRepository : ITRepository
  {
    private readonly DataContext _context;

    public TRepository(DataContext context)
    {
      _context = context;
    }

    public async Task<List<T>> GetAll<T>() where T : class =>
      await _context.Set<T>().ToListAsync();

    //getById
    public async Task<T> GetById<T>(int id) where T : class =>
      await _context.Set<T>().FindAsync(id);

    //create 
    public async Task<T> Create<T>(T entity) where T : class
    {
      _context.Set<T>().Add(entity);
      await _context.SaveChangesAsync();
      return entity;
    }
    public async Task Update<T>(T entity) where T : class
    {
      _context.Set<T>().Update(entity);
      await _context.SaveChangesAsync();
    }

    public async Task Remove<T>(T entity) where T : class
    {
      _context.Set<T>().Remove(entity);
      await _context.SaveChangesAsync();
    }
    public IQueryable<T> GetQueryable<T>() where T : class =>
      _context.Set<T>();
  }
}