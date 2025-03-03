using Microsoft.EntityFrameworkCore;

namespace SanAndres_Api.Database
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
  }
}