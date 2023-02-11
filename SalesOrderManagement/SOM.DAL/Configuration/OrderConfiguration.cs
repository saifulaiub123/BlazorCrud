using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SOM.Core.DBModel;

namespace SOM.DAL.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.State)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
