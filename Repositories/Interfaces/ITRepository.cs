namespace SanAndres_Api.Repositories.Interfaces
{
  public interface ITRepository
  {
    Task<List<T>> GetAll<T>() where T : class;
    Task<T> GetById<T>(int id) where T : class;
    Task<T> Create<T>(T entity) where T : class;
    Task Update<T>(T entity) where T : class;
    Task Remove<T>(T entity) where T : class;
    IQueryable<T> GetQueryable<T>() where T : class;
    Task CreateRange<T>(IEnumerable<T> entities) where T : class;
    Task UpdateRange<T>(IEnumerable<T> entities) where T : class;
    Task RemoveRange<T>(IEnumerable<T> entities) where T : class;
  }
}