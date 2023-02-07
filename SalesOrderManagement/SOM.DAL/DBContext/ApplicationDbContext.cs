
using Microsoft.EntityFrameworkCore;
using SOM.Core.DBModel;
using SOM.Core.IEntity;

namespace SOM.DAL.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<Window> Window { get; set; }
        public DbSet<Element> Element { get; set; }
        public DbSet<OrderWindow> OrderWindow { get; set; }
        public DbSet<WindowElement> WindowElement { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            foreach (var item in ChangeTracker.Entries<IAuditable>())
            {
                switch (item.State)
                {
                    case EntityState.Added:
                        item.Entity.DateCreated = DateTime.Now;
                        item.Entity.CreatedBy = 1;
                        item.Entity.UpdatedBy = 1;
                        break;
                    case EntityState.Modified:
                        item.Entity.LastUpdated = DateTime.Now;
                        item.Entity.UpdatedBy = 1;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}