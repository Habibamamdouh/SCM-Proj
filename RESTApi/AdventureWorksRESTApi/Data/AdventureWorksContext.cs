using AdventureWorksRESTApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AdventureWorksRESTApi.Data
{
    public class AdventureWorksContext : DbContext
    {
        public AdventureWorksContext(DbContextOptions<AdventureWorksContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}