using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OrderBoatNew.EntityFramework
{
    public class OrderBoatNewDbContextFactory : IDesignTimeDbContextFactory<OrderBoatNewDbContext>
    {
        public OrderBoatNewDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<OrderBoatNewDbContext>();
            options.UseSqlServer(@"Server=DESKTOP-PON2VF7\SQLEXPRESS;Database=OrderBoatNew;Trusted_Connection=True;");

            return new OrderBoatNewDbContext(options.Options);
        }
    }
}