using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OrderBoatNew.EntityFramework
{
    public class OrderBoatNewDbContextFactory
    {
        private readonly string _connectionString;

        public OrderBoatNewDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public OrderBoatNewDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<OrderBoatNewDbContext>();
            options.UseSqlServer(_connectionString);

            return new OrderBoatNewDbContext(options.Options);
        }
    }
}