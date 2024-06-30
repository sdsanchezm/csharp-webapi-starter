using Microsoft.EntityFrameworkCore;
using test2.Data;
using test2.Interfaces;
using test2.Models;

namespace test2.Services
{
    public class TestServices : ITestServices
    {
        private readonly DataContext _dbContext;

        public TestServices(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool TestInitial(TestModel t)
        {
            var a = _dbContext.TestDb.Add(t);
            return Save();
        }

        public bool Save()
        {
            try
            {
                var saved = _dbContext.SaveChanges();
                return saved > 0 ? true : false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error: {ex.Message}");
                return false;
            }
        }

    }
}
