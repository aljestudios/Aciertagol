using Aciertagol.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aciertagol.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<TeamEntity> Teams { get; set; }
    }
}
