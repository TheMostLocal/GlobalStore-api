using GlobalStore.Domain.Catalog
using Microsoft.EntityFrameworkCore;

namespace GlobalStore.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
        { }
        
        public DbSet <Item> Items { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initalize(builder);
        }
    }
}

