using Fatec.eCommT2.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace Fatec.eCommT2.infrastructure.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options)
        { }
            public DbSet<Product> products { get; set; }
            public DbSet<Category> categories { get; set; }
            public DbSet<Brand> brands { get; set; }
        
    }
}
