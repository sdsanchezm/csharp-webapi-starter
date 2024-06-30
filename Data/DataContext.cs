using Microsoft.EntityFrameworkCore;
using test2.Models;

namespace test2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<TestModel> TestDb { get; set; }

    }
}
