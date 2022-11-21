using amitranetapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace amitranetapi.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<School> school { get; set; }

    }
}
